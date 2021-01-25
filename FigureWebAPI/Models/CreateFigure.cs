using System;
namespace FigureWebAPI.Models {
    public class CreateFigure {
        public long Id { get; set; }
        public string NameFigure { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
    }
}
