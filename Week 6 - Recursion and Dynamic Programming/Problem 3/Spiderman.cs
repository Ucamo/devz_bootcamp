/*
¡Por fin terminó la pandemia! Durante la cuarentena jugaste mucho Spiderman Miles Morales y te encantó la ciudad de NY, así que decidiste ir a visitarla.
Durante tu visita te detuviste en una esquina de Manhattan y revisaste el mapa. La cuadrícula te sorprendió tanto que pensaste: ¿Cuántos caminos habrá para llegar de donde estoy a cualquier esquina? Supongamos que solo te vas a mover al este y al norte.
Escribe un programa que calcule el número de caminos de una esquina a otra dado el número de cuadras al este y al norte.

*/
class Spiderman {
    static void Main() {
        Test();
    }
    
    static void Test(){
        Console.WriteLine("N=2,E=2 Caminos:"+GetPaths(2,2));
        Console.WriteLine("N=3,E=2 Caminos:"+GetPaths(3,2));
        Console.WriteLine("N=3,E=3 Caminos:"+GetPaths(3,3));
        Console.WriteLine("N=4,E=4 Caminos:"+GetPaths(4,4));
        Console.WriteLine("N=5,E=5 Caminos:"+GetPaths(5,5));
    }
    
    static int GetPaths(int north, int east){
        int paths=0;
        int answer= CalculatePath(north,east,paths);
        return answer;
    }
    
    static int CalculatePath(int north, int east, int paths){
        if(north==1 && east==1){
            return 1;
        }
        if(north==0 && east==0){
            return 0;
        }
        if(north!=0 && east!=0){
            paths= CalculatePath(north-1,east,paths)+CalculatePath(north,east-1,paths);
        }        
        return paths;
    }
}