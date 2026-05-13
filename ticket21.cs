using System;



//билет 21
namespace Ticket
{
    //создаем делегат OnValueChanger который будет переделан в event (событие)
    delegate void OnValueChanger();
    class MyEvent
    {
        //создаем event (событие) из делегата OnValueChanger
        public event OnValueChanger  onvaluechanger;

        //поле к которому мы будем обращатся  через свойства
        private int PrivateValue;
       
       //само свойство для работы со свойством
        public int PublicValue
        {
            get { return myVar; }
            set 
            {
                
                myVar = value;
                //если в  event (событие ) есть какойто метод то событие произойдет
                if(onvaluechanger != null) onvaluechanger.Invoke();
            }
        }
         
        
    }
   
    class Program
    {
        
        static void Main(string[] args)
        { 
            
           
        }
    }
}