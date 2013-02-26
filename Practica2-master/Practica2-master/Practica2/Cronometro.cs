using System;
namespace Practica2
{
	public class Cronometro
	{
		private int horas;
		private int minutos;
		private int segundos;
		private int milisegundos; 
		private Utilerias utilerias;
		
		public Cronometro ()
		{
			this.horas = 0;
			this.minutos = 0;
			this.segundos = 0;
		    this.milisegundos = 0; 
			this.utilerias = new Utilerias();
		}
		
		public void iniciar(){
			this.iniciaProceso();			
		}
			
		
		private void iniciaProceso(){
			this.utilerias.limpiaPantalla();
			for(this.horas = 0; this.horas < 1000; this.horas++){
				for(this.minutos = 0; this.minutos < 60; this.minutos++){
					for(this.segundos = 0; this.segundos < 60; this.segundos++){
						for(this.milisegundos = 0; this.milisegundos < 60; this.milisegundos++){
							
							
						this.utilerias.imprimeTiempoActualmilisegundos(this.horas, this.minutos, this.segundos, this.milisegundos);
						this.utilerias.duerme1Segundomilisegundos();
						this.utilerias.limpiaPantalla();
					}
				}
			}

		}

	}
  }
}