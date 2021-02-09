using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            if (color.ColorName.Length>=2)
            {
                _colorDal.Add(color);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Color Added Successfully");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! The character of color name must not be shorter than 2");
                Console.ResetColor();
            }
        }

        public void Delete(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Color Deleted Successfully");
        }

        public void Update(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Color Updated Successfully");
        }
    }
}
