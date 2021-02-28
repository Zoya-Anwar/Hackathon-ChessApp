using System.Text.RegularExpressions;
public class CheckInput {

	//This method requires your input
	public static bool checkCoordinateValidity(string input){
        Regex rx = new Regex("([a-h]){1}[1-8]");
        return rx.IsMatch(input);
	}
}