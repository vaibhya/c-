using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapApp.Model
{
    class Rectangle
    {
        private int _height;
        int _width;
        private BorderStyle _border;

        
        public Rectangle(int height,int width) : this(height,width, BorderStyle.SOLID)
        {
            
        }
        public Rectangle(int height,int width,BorderStyle border)
        {
            _height = height;
            _width = width;
            _border = border;
        }
        
        public int CalculateArea()
        {
            return _height * _width;
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            
        }
        public BorderStyle Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
            }
        }
    }
}
