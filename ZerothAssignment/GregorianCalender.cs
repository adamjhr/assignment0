namespace ZerothAssignment;

public class GregorianCalender {

    public bool IsLeapYear(int year) {
        if (year == 0) return true;
        if (year % 100 == 0) return false;
        return (year % 4) == 0;
    }

}