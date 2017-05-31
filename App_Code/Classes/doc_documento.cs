using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de doc_documento
/// </summary>
public class doc_documento
{
    private mot_motorista mot_id;
    private tdo_tipodocumento tdo_id;

    public mot_motorista Mot_id
    {
        get
        {
            return mot_id;
        }

        set
        {
            mot_id = value;
        }
    }

    public tdo_tipodocumento Tdo_id
    {
        get
        {
            return tdo_id;
        }

        set
        {
            tdo_id = value;
        }
    }
}