using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    internal class RefrigeratedContainer : Container
    {
        private int id;
        private float weight;
        private bool isRefrigerated;
        private List<string> merchandise;
        private string color;

        public int _id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public float _weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public bool _isRefrigerated
        {
            get
            {
                return isRefrigerated;
            }
            set
            {
                isRefrigerated = value;
            }
        }
        public string _color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public List<string> _merchandise
        {
            get
            {
                return merchandise;
            }
            set
            {
                merchandise = value;
            }
        }

        public RefrigeratedContainer(int id, float weight, bool isRefrigerated, List<string> merchandise, string color)
        {
            _id = id;
            _weight = weight;
            _isRefrigerated = isRefrigerated;
            _merchandise = merchandise;
            _color = color;
        }
    }
}
