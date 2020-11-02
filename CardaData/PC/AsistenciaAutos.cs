﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CardaData.PC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AsistenciaAutos recording.
    /// </summary>
    [TestModule("6731f328-a50f-49ed-90e2-aa545cdca218", ModuleType.Recording, 1)]
    public partial class AsistenciaAutos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static AsistenciaAutos instance = new AsistenciaAutos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AsistenciaAutos()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AsistenciaAutos Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("8bb4d90e-0931-42e5-a69e-df43fdd1058a")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lbl_AsistenciasAutos'", repo.ApplicationUnderTest.lbl_AsistenciasAutosInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.lbl_AsistenciasAutosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Buscar_AsistAutos' at Center.", repo.ApplicationUnderTest.Btn_Buscar_AsistAutosInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Btn_Buscar_AsistAutos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Fila_Asist_Autos'", repo.ApplicationUnderTest.Fila_Asist_AutosInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.Fila_Asist_AutosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Editar_AsistAutos' at Center.", repo.ApplicationUnderTest.Btn_Editar_AsistAutosInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Btn_Editar_AsistAutos.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_Producto_A_AsistAutos' at Center.", repo.ApplicationUnderTest.txt_Producto_A_AsistAutosInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.txt_Producto_A_AsistAutos.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Select_Producto_E_AsistAutos' at Center.", repo.ApplicationUnderTest.Select_Producto_E_AsistAutosInfo, new RecordItemIndex(5));
            //repo.ApplicationUnderTest.Select_Producto_E_AsistAutos.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_ResultadosDeLaBusqueda' at Center.", repo.ApplicationUnderTest.lbl_ResultadosDeLaBusquedaInfo, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.lbl_ResultadosDeLaBusqueda.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Select_sura_ca7_vehicle_assistance_1' at Center.", repo.ApplicationUnderTest.Select_sura_ca7_vehicle_assistance_1Info, new RecordItemIndex(7));
            //repo.ApplicationUnderTest.Select_sura_ca7_vehicle_assistance_1.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Actualizar_AsistAutos' at Center.", repo.ApplicationUnderTest.Btn_Actualizar_AsistAutosInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Btn_Actualizar_AsistAutos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_Btn_Actualizar_AsistAutos'", repo.ApplicationUnderTest.Copy_of_Btn_Actualizar_AsistAutosInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.ApplicationUnderTest.Copy_of_Btn_Actualizar_AsistAutosInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Editar_AsistAutos' at Center.", repo.ApplicationUnderTest.Btn_Editar_AsistAutosInfo, new RecordItemIndex(10));
            //repo.ApplicationUnderTest.Btn_Editar_AsistAutos.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_Producto_E_AsistAutos' at Center.", repo.ApplicationUnderTest.txt_Producto_E_AsistAutosInfo, new RecordItemIndex(11));
            //repo.ApplicationUnderTest.txt_Producto_E_AsistAutos.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Select_Producto_A_AsistAutos' at Center.", repo.ApplicationUnderTest.Select_Producto_A_AsistAutosInfo, new RecordItemIndex(12));
            //repo.ApplicationUnderTest.Select_Producto_A_AsistAutos.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Actualizar_AsistAutos' at Center.", repo.ApplicationUnderTest.Btn_Actualizar_AsistAutosInfo, new RecordItemIndex(13));
            //repo.ApplicationUnderTest.Btn_Actualizar_AsistAutos.Click();
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
