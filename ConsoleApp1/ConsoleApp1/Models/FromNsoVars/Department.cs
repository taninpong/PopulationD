using System.Collections.Generic;

namespace NSOWater.HotMigration.Models
{
      public class Department
    {
        public string _id { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
    }
    public class Properties
    {
        public int? fig_id { get; set; }
        public string ea_code_14 { get; set; }
        public string ea_type { get; set; }
        public string com_name { get; set; }
        public string tam_name { get; set; }
        public string dis_name { get; set; }
        public string pro_name { get; set; }
        public string ea_remark { get; set; }
        public string muni_name { get; set; }
        public string upd_date { get; set; }
        public string year { get; set; }
        public string old_ea_ref { get; set; }
        public int? moo { get; set; }
        public int? hh_num { get; set; }
        public int? map_status { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<List<List<List<double?>>>> coordinates { get; set; }
    }

}
