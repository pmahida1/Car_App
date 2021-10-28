using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_App.Model
{
    public class CarModel
    {
        [PrimaryKey] [AutoIncrement]
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public string CarYear { get; set; }
        public string FuelMode { get; set; }
        public string DrivenKM { get; set; }
        public string Average { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
        public bool IsFavorite { get; set; }
    }
}
