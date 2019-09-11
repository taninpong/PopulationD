using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSOWater.HotMigration.Models
{
    public class HasWarningWaterUsage1V
    {
        private static BuildingType? BDType { get; set; }
        private static double AvgRent { get; set; }
        private static double AvgPrice { get; set; }

        public int HasWarningWater(WaterUsageRate waterUsageRate)
        {
            var waterUsage = waterUsageRate.WaterUsage;
            BDType = waterUsageRate.BuildingType.Value;
            var residence = waterUsageRate.Residence;
            var communities = waterUsageRate.Communities;
            AvgRent = communities?.Average(it => it.Management?.WaterServices?.Sum(i => i.MeterRentalFee)) ?? 0;
            AvgPrice = communities?.Average(it => it.Management?.WaterServices?.Sum(i => i.PlumbingPrice)) ?? 5;

            var anySkip = isSkip(waterUsage?.Plumbing?.MWA) || isSkip(waterUsage?.Plumbing?.PWA) || isSkip(waterUsage?.Plumbing?.Other);
            if (anySkip)
            {
                return 0;
            }
            else
            {
                var sum = CalcPlumping(waterUsage?.Plumbing)
                    + CalcGroundWater(waterUsage?.GroundWater)
                    + CalcPool(waterUsage?.Pool)
                    + CalcRiver(waterUsage?.River)
                    + CalcIrrigation(waterUsage?.Irrigation)
                    + CalcRain(waterUsage?.Rain)
                    + CalcBuying(waterUsage?.Buying);
                var member = residence?.MemberCount;
                var rate = sum / member;
                return member > 0 && (rate < 3.65 || 164.25 < rate) ? 1 : 0;
            }
        }

        private bool isSkip(PlumbingInfo plumbing)
        {
            if (plumbing?.Doing == true)
            {
                var quantity = plumbing?.PlumbingUsage?.WaterQuantity;
                return quantity == WaterQuantity.UnknowNoMeter || quantity == WaterQuantity.UnknowExcepted;
            }
            return false;
        }

        private double CalcPlumping(Plumbing plumbing)
        {
            var sum = CalcMWA(plumbing) + CalcPWA(plumbing) + CalcOther(plumbing);
            return sum;
        }

        private double CalcMWA(Plumbing plumbing)
        {
            if (plumbing?.MWA?.Doing == true)
            {
                try
                {
                    if (plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                    {
                        return plumbing.MWA.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityMWA.Drink.Value * 12 / 100.0;
                    }
                    else if (plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                    {
                        return plumbing.MWA.PlumbingUsage.WaterBill.Value / WaterPricePlumping("MWA");
                    }
                }
                catch (System.Exception) { }
                return 0;
            }
            return 0;
        }

        private double CalcPWA(Plumbing plumbing)
        {
            if (plumbing?.PWA?.Doing == true)
            {
                try
                {
                    if (plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                    {
                        return plumbing.PWA.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityPWA.Drink.Value * 12 / 100.0;
                    }
                    else if (plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                    {
                        return plumbing.PWA.PlumbingUsage.WaterBill.Value / WaterPricePlumping("PWA");
                    }
                }
                catch (System.Exception) { }
                return 0;
            }
            return 0;
        }

        private double CalcOther(Plumbing plumbing)
        {
            if (plumbing?.Other?.Doing == true)
            {
                try
                {
                    if (plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
                    {
                        return plumbing.Other.PlumbingUsage.CubicMeterPerMonth.Value * plumbing.WaterActivityOther.Drink.Value * 12 / 100.0;
                    }
                    else if (plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
                    {
                        return (plumbing.Other.PlumbingUsage.WaterBill.Value - AvgRent) / AvgPrice;
                    }
                }
                catch (System.Exception) { }
                return 0;
            }
            return 0;
        }

        private double CalcGroundWater(GroundWater groundWater)
        {
            var sum = CalcPrivate(groundWater?.PrivateGroundWater) + CalcPublic(groundWater?.PublicGroundWater);
            return sum;
        }

        private double CalcPrivate(PrivateGroundWater privateGroundWater)
        {
            if (privateGroundWater?.Doing == true)
            {
                return privateGroundWater.WaterResourceCount > 0 ? privateGroundWater.WaterResources.Where(it => it != null).Sum(it =>
                {
                    try
                    {
                        if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.CubicMeterPerMonth)
                        {
                            return it.UsageType.UsageCubicMeters.Value * it.WaterActivities.Drink.Value * 12 / 100.0;
                        }
                        else if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.WaterBill)
                        {
                            return it.UsageType.WaterBill.Value / WaterPrice(it.Location);
                        }
                        else if (it.UsageType.GroundWaterQuantity == GroundWaterQuantity.Unknown && it.HasPump.Value)
                        {
                            return CalcPumps(it.Pumps, true);
                        }
                    }
                    catch (System.Exception) { }
                    return 0;
                }) : 0;
            }
            return 0;
        }

        private double CalcPublic(PublicGroundWater publicGroundWater)
        {
            if (publicGroundWater?.Doing == true)
            {
                return publicGroundWater.WaterResourceCount > 0 ? publicGroundWater.WaterResources.Where(it => it != null).Sum(it =>
                {
                    try
                    {
                        if (it.HasCubicMeterPerMonth == true)
                        {
                            return it.CubicMeterPerMonth.Value * it.WaterActivities.Drink.Value * 12 / 100.0;
                        }
                        else if (it.HasPump == true)
                        {
                            return CalcPumps(it.Pumps, true);
                        }
                    }
                    catch (System.Exception) { }
                    return 0;
                }) : 0;
            }
            return 0;
        }

        private double CalcRiver(River river)
        {
            return (river?.HasPump == true && river?.PumpCount > 0) ? CalcPumps(river.Pumps, false) : 0;
        }

        private double CalcPool(Pool pool)
        {
            if (pool?.Doing == true)
            {
                return pool.WaterResourceCount > 0 ? pool.WaterResources.Where(it => it != null).Sum(it =>
                {
                    try
                    {
                        if (it.HasCubicMeterPerMonth == true)
                        {
                            return it.CubicMeterPerMonth.Value * it.WaterActivities.Drink.Value * 12 / 100.0;
                        }
                        else if (it.HasPump == true)
                        {
                            return CalcPumps(it.Pumps, false);
                        }
                    }
                    catch (System.Exception) { }
                    return 0;
                }) : 0;
            }
            return 0;
        }

        private double CalcIrrigation(Irrigation irrigation)
        {
            if (irrigation?.HasCubicMeterPerMonth == true)
            {
                try
                {
                    return irrigation.CubicMeterPerMonth.Value * irrigation.WaterActivities.Drink.Value * 12 / 100.0;
                }
                catch (System.Exception) { }
                return 0;
            }
            else if (irrigation?.HasPump == true)
            {
                return CalcPumps(irrigation.Pumps, false);
            }
            return 0;
        }

        private double CalcRain(Rain rain)
        {
            var sum = (rain?.RainContainers?.Where(it => it != null).Sum(it => (it.Size?.Replace(",", "").Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).Average() ?? 0) * (it.Count ?? 0)) ?? 0)
            * (rain?.WaterActivities?.Drink ?? 0) / 100.0;
            return sum;
        }

        private double CalcBuying(Buying buying)
        {
            var sum = ((buying?.Package?.Where(it => it != null).Sum(it => (it.Size ?? 0) * (it.Drink ?? 0) / (!string.IsNullOrEmpty(it.Name) && it.Name.Contains("ขวด") ? 1000 : 1))) ?? 0) * 12 / 100.0;
            return sum;
        }

        private double CalcPumps(List<Pump> pumps, bool isGround)
        {
            return pumps.Where(it => it != null).Sum(it =>
            {
                return (it.PumpAuto.Value == false) ? it.HoursPerPump.Value * it.NumberOfPumpsPerYear.Value * CalcPumpRate(it, isGround) / 12 : 0;
            });
        }

        private double CalcPumpRate(Pump pump, bool isGround)
        {
            if (pump.HasPumpRate == true)
            {
                return pump.PumpRate.Value;
            }
            else
            {
                var pumpcal = new PumpCal();
                var listPump = isGround ? pumpcal.listPumpGroundWater : pumpcal.listSurfaceWater;
                try
                {
                    var pumpRate = listPump.FirstOrDefault(it => it.EnergyFromPump == pump.EnergySource
                        && it.PumpType == pump.PumpType && it.Power == pump.HorsePower
                        && it.SuctionPipeSize == pump.SuctionPipeSize && it.PipelineSize == pump.PipelineSize).PumpRate;
                    return pumpRate.Value;
                }
                catch (Exception e)
                {
                    var pumpRate = listPump.FirstOrDefault(it => it.PumpType == pump.PumpType && it.Power == pump.HorsePower
                           && it.SuctionPipeSize == pump.SuctionPipeSize && it.PipelineSize == pump.PipelineSize)?.PumpRate
                           ?? (pump.PumpType.StartsWith("ปั๊มหอยโข่ง") ? 1500 : 0);
                    return pumpRate;
                }
            }
        }

        private double WaterPricePlumping(string type)
        {
            switch (type)
            {
                case "MWA": return isInBuildingType() ? 10.5 : 13;
                case "PWA": return isInBuildingType() ? 16.6 : 26;
                default: return 0;
            }
        }

        private double WaterPrice(Location location)
        {
            return isIn7Areas(location) ? isInBuildingType() ? 8.5 : 13 : 3.5;
        }

        private bool isIn7Areas(Location location)
        {
            var areas = new List<string>
            {
                "กรุงเทพมหานคร", "พระนครศรีอยุธยา", "ปทุมธานี", "สมุทรสาคร", "สมุทรปราการ", "นนทบุรี", "นครปฐม"
            };
            return areas.Any(it => it == location.Province);
        }

        private bool isInBuildingType()
        {
            var types = new List<BuildingType>
            {
                BuildingType.SingleHouse, BuildingType.TownHouse,
                BuildingType.ShopHouse, BuildingType.Apartment,
                BuildingType.Religious, BuildingType.GreenHouse
            };
            return types.Any(it => it == BDType);
        }
    }
}
