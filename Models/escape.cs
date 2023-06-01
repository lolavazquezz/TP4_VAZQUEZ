public static class escape{
    private static string[] incognitaSalas{get; set;}= new string[4]{"","","",""};
    private static int estadoJuego{get; set;}=1;
    static escape(){}
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool resolverSala(int sala, string incognita){
        if ((sala==estadoJuego)&&(incognita==incognitaSalas[sala-1])){ 
            estadoJuego++; 
            return true;
        }
        else return false;
    }
}