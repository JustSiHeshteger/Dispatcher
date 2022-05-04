using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DispatcherAdmin.Model
{
    internal class AutobusModel
    {
        private int _idAutobus;
        private string _numberAutobus;


        [DisplayName("Id Автобуса")]
        public int IdAutobus 
        { 
            get => _idAutobus;
            set => _idAutobus = value; 
        }


        [DisplayName("Номер автобуса")]
        [Required(ErrorMessage = "Номер автобуса не может быть пустым")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Номер автобуса должен быть от 2 до 10 символов")]
        public string NumberAutobus 
        { 
            get => _numberAutobus; 
            set => _numberAutobus = value; 
        }
    }
}
