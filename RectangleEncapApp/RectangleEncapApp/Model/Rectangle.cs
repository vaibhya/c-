using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleEncapApp.Model
{
    class Rectangle
    {
        private int _height;
        private int _width;
        private BorderStyle _border;

        public Rectangle(int height,int width)
        {
            _height = height;
            _width = width;
        }
        public Rectangle(int height,int width,BorderStyle border)
        {
            _height = height;
            _width = width;
            _border = border;
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public BorderStyle GetBorder()
        {
            return _border;
        }
        public int CalculateArea()
        {
            return _height * _width;
        }
        public void SetBorder(BorderStyle border)
        {
            _border = border;
        }
    }
}
