namespace EJERCICIO_1{
    public class TextInput{
        private string cadena = string.Empty; // declaro cadena vacia

        public virtual bool CaracterEsValido(char caracter){
        return char.IsLetterOrDigit(caracter); // Devuelve true si es una letra o un dígito decimal; 
                                                // de lo contrario, false.
        }

        public void Add(char c){
            if(CaracterEsValido(c)){
                cadena += c;
            }  
         }

         public string GetValue(){
            return cadena;
        }    

    }
}