namespace EJERCICIO_1{
    public class NumericInput : TextInput{

        public override bool CaracterEsValido(char caracter){
        return char.IsDigit(caracter); //Indica si el carácter se clasifica como un dígito decimal.
        }

    }
}