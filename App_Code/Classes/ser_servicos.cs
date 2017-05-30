using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ser_servicos
/// </summary>
public class ser_servicos
{
	private int ser_id;
    private string ser_datafim;
    private string ser_origem;
    private string ser_datainicio;
    private string ser_destino;
    private int ser_lugares;
    private mot_motorista mot_id;

    public int Ser_lugares
    {
        get { return ser_lugares; }
        set { ser_lugares = value; }
    }
    

    public global:: mot_motorista Mot_id
    {
        get { return mot_id; }
        set { mot_id = value; }
    }

    public string Ser_destino
    {
        get { return ser_destino; }
        set { ser_destino = value; }
    }

    public string Ser_datainicio
    {
        get { return ser_datainicio; }
        set { ser_datainicio = value; }
    }
    

    public string Ser_datafim
    {
        get { return ser_datafim; }
        set { ser_datafim = value; }
    }
    

    public string Ser_origem
    {
        get { return ser_origem; }
        set { ser_origem = value; }
    }


    public int Ser_id
    {
        get { return ser_id; }
        set { ser_id = value; }
    }
     


}