import java.io.Console;

public class Execute {
    private Engine _eventsEngine;
    private int _getNum1;
    private int _getNum2;

    public Execute(){
        _eventsEngine = new Engine();
    }
    public void RunCalculator(){
        ConsoleMsgs.welcomeMsg();
        ConsoleMsgs.firstNum();
        _getNum1 = _eventsEngine.getNum1();
        ConsoleMsgs.secondNum();
        _getNum2 = _eventsEngine.getNum2();
        _eventsEngine.buffer();
        ConsoleMsgs.operatorSelection();
        String op = _eventsEngine.operator();
        _eventsEngine.calculate(_getNum1, _getNum2, op);
    }
}
