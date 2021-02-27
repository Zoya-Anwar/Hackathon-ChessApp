using System.Text.RegularExpressions;
public class CheckInput {

	//This method requires your input
	public static bool checkCoordinateValidity(string input){
        Regex rx = new Regex("([1-8][a-h]){1}");
        return rx.IsMatch(input);
	}
}