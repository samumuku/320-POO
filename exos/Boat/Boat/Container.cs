using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace Boat
{
    class Container : IContainer
    {
        private int _id;
        private float _weight;
        private bool _isRefrigerated;
        private List<string> _merchandise;
        private string _color;

        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }   
        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
        public bool IsRefrigerated
        {
            get
            {
                return _isRefrigerated;
            }
            set
            {
                _isRefrigerated = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public List<string> Merchandise
        {
            get
            {
                return _merchandise;
            }
            set
            {
                _merchandise = value;
            }
        }

        public Container(int id, float weight, bool isRefrigerated, List<string> merchandise, string color)
        {
            _id = id;
            _weight = weight;
            _isRefrigerated = isRefrigerated;
            _merchandise = merchandise;
            _color = color;
        }
        public void ViewContent()
        {
            foreach (var merchandise in _merchandise)
            {
                Console.WriteLine(merchandise);
            }
        }

        public void AddMerchandise(string item)
        {
            _merchandise.Add(item);
        }
    }
}