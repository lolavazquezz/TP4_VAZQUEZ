public static class escape{
    private static string[] incognitaSalas{get; set;}= new string[4]{"AAPDAC","GANCHO","SRNE","4"};
    private static int estadoJuego{get; set;}=1;
    static escape(){}
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool resolverSala(int sala, string incognita){
        if (incognita==incognitaSalas[sala-1]){ 
            if (sala==4) estadoJuego=1;
            else estadoJuego++; 
            return true;
        }
        else return false;
    }
}