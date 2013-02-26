using System;
namespace Practica2
{
	public class Reloj
	{	
		private int horas;
		private int minutos;
		private int segundos;
		private Utilerias utilerias;
		
		public Reloj ()
		{
			this.horas = 0;
			this.minutos = 0;
			this.segundos = 0;
			this.utilerias = new Utilerias();
		}
		
		public void iniciar(){
			this.obtenHoraLocal();
			this.iniciaProceso();
		}
		
		private void obtenHoraLocal(){
			this.horas = DateTime.Now.Hour;
			this.minutos = DateTime.Now.Minute;
			this.segundos = DateTime.Now.Second;
		}
		
		private void iniciaProceso(){
			this.utilerias.limpiaPantalla();
			while(true){
				for(this.horas = this.horas; this.horas < 24; this.horas++){
					for(this.minutos = this.minutos; this.minutos < 60; this.minutos++){
						for(this.segundos = this.segundos; this.segundos < 60; this.segundos++){
							this.utilerias.imprimeTiempoActual(this.horas, this.minutos, this.segundos);
							this.utilerias.duerme1Segundo();
							this.utilerias.limpiaPantalla();
						}
						this.segundos = 0;
					}
					this.minutos = 0;	
				}
				this.reiniciarDia();
				
			}
		}
		
		private void reiniciarDia(){
			this.horas = 0;
			this.minutos = 0;
			this.segundos = 0;
		}
	}
}