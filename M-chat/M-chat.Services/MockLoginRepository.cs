//using M_chat.Models;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;

//namespace M_chat.Services
//{
//    public class MockLoginRepository : Ilogin
//    {
//        private List<Secion> _secions;
//        public MockLoginRepository()
//        {
//            _secions = new List<Secion>() {

// new Secion{ ASIN="1234567890", Capacity = 60.0, ContainerId = 1, ItemModelNumber =
//"12345", ItemWeight = "45.5", Location = "Domicilio Conocido", Manufacturer =
//"Oshrans", Owner = "Taller el veloz", ProductDimensions = ""},
// new Secion{ ASIN="0987654321", Capacity = 40.0, ContainerId = 2, ItemModelNumber =
//"67890", ItemWeight = "30", Location = "Domicilio Conocido", Manufacturer =
//"Rythmon", Owner = "RefaCar", ProductDimensions = ""},
// new Secion{ ASIN="1234567890", Capacity = 100.0, ContainerId = 3, ItemModelNumber =
//"24680", ItemWeight = "70", Location = "Domicilio Conocido", Manufacturer =
//"Rythmon", Owner = "Taller la Anita", ProductDimensions = ""},
// new Secion{ ASIN="0987654321", Capacity = 60.0, ContainerId = 4, ItemModelNumber =
//"13579", ItemWeight = "45.5", Location = "Domicilio Conocido", Manufacturer =
//"Oshrans", Owner = "Autoservicio Mythic Car", ProductDimensions = ""},
// new Secion{ ASIN="1234567890", Capacity = 50.0, ContainerId = 5, ItemModelNumber =
//"12378", ItemWeight = "50", Location = "Domicilio Conocido", Manufacturer = "LG",
//Owner = "Taller la Carcacha", ProductDimensions = ""}
// };
//        }
//        public IEnumerable<Secion> GetAll()
//        {
//            return _secions;
//        }
//    }
//}
