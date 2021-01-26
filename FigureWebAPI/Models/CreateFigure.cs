using System;
using System.ComponentModel.DataAnnotations;

namespace FigureWebAPI.Models {
    public class CreateFigure {
        public long Id { get; set; }
        public string Name { get; set; }

        public int FirstSide { get; set; }

        public int SecondSide { get; set; }

        public int ThirdSide { get; set; }
        public int FigureArea { get; set; }

        public CreateFigure(int firstSide, int secondSide, int thirdSide) {
            FirstSide = (firstSide);
            SecondSide = (secondSide);
            ThirdSide = (thirdSide);

            var halfPerimetr = (firstSide + secondSide + thirdSide) / 2;
            var area = Math.Sqrt(halfPerimetr * (halfPerimetr - firstSide) *
                                                (halfPerimetr - secondSide) *
                                                (halfPerimetr - thirdSide));
            FigureArea = Convert.ToInt32(area);
        }   
    }
}
