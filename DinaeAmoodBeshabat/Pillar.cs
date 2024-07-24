using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinae_Amood_Beshabat
{
    internal class Pillar
    {
        private int _height;
        private int _width;
        private string _location;
        private string _statusLocation;

        public int Height { get { return _height; } set { _height = value; } }
        public int Width { get { return _width; } set { _width = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string StatusLocation { get 
            {
                switch (_location)
                {
                    case "רשות היחיד":
                        _statusLocation = "רשות היחיד";
                        break;
                    case "רשות הרבים":
                        if (_width < 4)
                        {
                            _statusLocation = "מקום פטור";
                        }
                        else
                        {
                            if (_height >= 10)
                            {
                                _statusLocation = "רשות היחיד";
                            }
                            else if (_height < 10 && _height >= 3)
                            {
                                _statusLocation = "כרמלית";
                            }
                            else if (_height < 3 && _height > 0)
                            {
                                _statusLocation = "רשות הרבים";
                            }
                            else { _statusLocation = "Erorre"; }



                        }
                        break;

                    case "כרמלית":
                        if (Width > 4) 
                        {
                         if (Height >= 10) 
                            {
                                _statusLocation = "רשות היחיד";
                            }
                         else if (Height < 10 && Height > 0) 
                            {
                                _statusLocation = "כרמלית";
                            }
                        }
                        else if (Height >= 10) 
                        {
                            _statusLocation = "לפי הטור דינו ככרמלית, לפי רש''י דינו כמקום פטור";
                        }
                        break;


                }
                return _statusLocation;
            } 
        }

    }

    
}
