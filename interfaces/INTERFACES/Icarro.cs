using System;
namespace interfaces.INTERFACES
{
	
        internal interface ICarro
    { 
public String Marca { get; set; }

public String Color { get; set; }

public int Modelo { get; set; }
        
public String GetVelocidadActual();

public void EncenderCarro();
        
public String Acelerar(int cuanto);
    }
}

