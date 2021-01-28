using System;
using System.ComponentModel.DataAnnotations;

namespace FigureWebAPI.Models {
    public class CreateFigure {
        public long Id { get; set; }
        [Required(ErrorMessage = "Укажите имя фигуры")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Длина стороны должна быть положительная")]
        public double FirstSide { get; set; }
        [Range(1, 100, ErrorMessage = "Длина стороны должна быть положительная")]
        public double SecondSide { get; set; }
        [Range(1, 100, ErrorMessage = "Длина стороны должна быть положительная")]
        public double ThirdSide { get; set; }
        public double FigureArea { get; set; }

        public CreateFigure(double firstSide, double secondSide, double thirdSide) {
            FirstSide = (firstSide);
            SecondSide = (secondSide);
            ThirdSide = (thirdSide);

            var halfPerimetr = (firstSide + secondSide + thirdSide) / 2;
            var area = Math.Sqrt(halfPerimetr * (halfPerimetr - firstSide) *
                                                (halfPerimetr - secondSide) *
                                                (halfPerimetr - thirdSide));
            FigureArea = Convert.ToDouble(area);
        }   
    }
}
