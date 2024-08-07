
// ************************************************************************
// Prueba 02
// Josue Chicaiza - Daniel Tapia
// Fecha de realización: 07/08/2024
// Fecha de entrega: 07/08/2024
// Resultados:

// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace prueba2_JosueC_DanielT
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IValidadorCT" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IValidadorCT
    {
        [OperationContract]
        void DoWork();
    }
}
