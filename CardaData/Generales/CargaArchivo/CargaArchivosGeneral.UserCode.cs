﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CardaData.Generales.CargaArchivo
{
    public partial class CargaArchivosGeneral
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void EsperaFinalizarProceso()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            
            int i =0;
            Report.Info("Info: ","Inicia procesamiento de archivo...");
            while(!repo.ApplicationUnderTest.Copy_of_txt_ArchivoCargado_qa2Info.Exists(5000)){
            	i++;
            	Delay.Milliseconds(25000);
            	
            	if(repo.ApplicationUnderTest.lbl_ErrorEnLaSolicitudDeHTTP503Info.Exists(5000)){
            		Report.Info("Info: ","Mostró el Error HTTP503");
            		repo.ApplicationUnderTest.btn_AceptarError.Click();
            		Keyboard.Press("{F5}");
            		Report.Info("Info: ","Se presionó F5...");
            	}
            	
            	if( i == 60 ){ //verificar para incluir o no la carga del archivo de la muerte
            		Report.Failure("Error:","Tiempo de espera agotado para el procesamiento de archivo.");
            	
            	}
            
            }
            
            Report.Success("Éxito: ","Finalizó el procesamiento del archivo.");
            //Keyboard.Press("{F5}");
        }

        public void EsperaFinalizarCarga()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            
            bool x = true;
            int i = 0;
            Report.Info("Info: ","Inicia carga de archivo...");
            while (x) {
            	
            	i++;
            	if(repo.ApplicationUnderTest.Copy_of_CargandoArchivoSInfo.Exists(5000)){
            		
            		Delay.Milliseconds(25000);
            		
            	}else{
            		Report.Success("Éxito: ","Finalizó la carga del archivo.");
            		x = false;
            	}
            	
            	if (i == 20){
            		Report.Failure("Error:","Tiempo de espera agotado para la carga de archivo.");
            		x = false;
            	}
            
            }
        }

    }
}
