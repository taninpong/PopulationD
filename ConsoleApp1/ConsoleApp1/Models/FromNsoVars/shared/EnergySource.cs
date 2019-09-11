namespace NSOWater.HotMigration.Models
{
    /// <summary>
    /// แหล่งพลังงาน
    /// </summary>
    // TODO:
    public enum EnergySource
    {
        /// <summary>
        /// ใช้ไฟฟ้า
        /// </summary>
        ElecticPump = 1,
        /// <summary>
        /// ใช้น้้ามันดีเซล(โซล่า)
        /// </summary>
        SolaPump = 2,
        /// <summary>
        /// ใช้น้้ามันเบนซิน
        /// </summary>
        PetrolPump = 3,
        
        /// <summary>
        /// รถไถเดินตาม
        /// </summary>
        TwoWheeledTractors = 4

    }
}