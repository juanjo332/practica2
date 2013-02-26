using System;

namespace Practica2
{
	class Principal
	{
		public void muestraMenu(){
			Console.WriteLine("Menu");
			Console.WriteLine("1 Reloj");
			Console.WriteLine("2 Cronometro");
		}
		
		
		public void leerEntrada(){
			int opcion = int.Parse(Console.ReadLine());
			if(opcion == 1){
				Reloj reloj = new Reloj();
				reloj.iniciar();
			}else{
				Cronometro cronometro = new Cronometro();
				cronometro.iniciar();
			}
		}
		
		public static void Main (string[] args)
		{
			
			Principal programa = new Principal();
			programa.muestraMenu();
			programa.leerEntrada();
		}
	}
}