using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for usu_usuario_tipoconta
/// </summary>
public class usu_usuario_tipoconta
{

    private string usu_datainicio;
    private tip_tipoconta tip_id;
    private string usu_datafim;
    private usu_usuario usu_id;

    public string Usu_datainicio
    {
        get { return usu_datainicio; }
        set { usu_datainicio = value; }
    }
    
    public string Usu_datafim
    {
        get { return usu_datafim; }
        set { usu_datafim = value; }
    }

    public usu_usuario Usu_id
    {
        get { return usu_id; }
        set { usu_id = value; }
    }
    
    public tip_tipoconta Tip_id
    {
        get { return tip_id; }
        set { tip_id = value; }
    }

}