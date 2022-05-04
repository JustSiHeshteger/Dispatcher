using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DispatcherAdmin.Model
{
    internal class ClientModel
    {
        private int _id;
        private string _numberPhone;
        private string _name;
        private string _surname;

        [DisplayName("ID клиента")]
        public int Id 
        {
            get => _id; 
            set => _id = value; 
        }

        [DisplayName("Номер телефона")]
        [Required(ErrorMessage = "Номер телефона не сможет быть пустым")]
        [StringLength(11, MinimumLength = 9, ErrorMessage = "Длина номера должна быть от 9 до 11 символов")]
        public string NumberPhone 
        { 
            get => _numberPhone; 
            set => _numberPhone = value;
        }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Имя не может быть пустым")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 30 символов")]
        public string Name 
        { 
            get => _name;
            set => _name = value;
        }

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Фамимлия не может быть пустой")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 30 символов")]
        public string Surname 
        { 
            get => _surname;
            set => _surname = value;
        }
    }
}
