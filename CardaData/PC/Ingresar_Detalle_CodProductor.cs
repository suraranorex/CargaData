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
    ///The Ingresar_Detalle_CodProductor recording.
    /// </summary>
    [TestModule("0734b97b-bdb5-4f36-8e8c-d2eb7b2ae77b", ModuleType.Recording, 1)]
    public partial class Ingresar_Detalle_CodProductor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static Ingresar_Detalle_CodProductor instance = new Ingresar_Detalle_CodProductor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ingresar_Detalle_CodProductor()
        {
            PASS = "2344";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ingresar_Detalle_CodProductor Instance
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

        /// <summary>
        /// Gets or sets the value of variable PASS.
        /// </summary>
        [TestVariable("0b3b15b6-0e6a-4d59-aa5a-6bbfd31eeb3e")]
        public string PASS
        {
            get { return repo.PASS; }
            set { repo.PASS = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.bttn_Limpiar' at Center.", repo.ApplicationUnderTest.bttn_LimpiarInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.bttn_Limpiar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.input_UnidadDeNegocio' at Center.", repo.ApplicationUnderTest.input_UnidadDeNegocioInfo, new RecordItemIndex(2));
            //repo.ApplicationUnderTest.input_UnidadDeNegocio.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.input_UnidadDeNegocio'.", repo.ApplicationUnderTest.input_UnidadDeNegocioInfo, new RecordItemIndex(3));
            //repo.ApplicationUnderTest.input_UnidadDeNegocio.PressKeys("{Back}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_Busqueda' at Center.", repo.ApplicationUnderTest.txt_BusquedaInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.txt_Busqueda.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            //Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductor'", repo.ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductorInfo, new ActionTimeout(15000), new RecordItemIndex(6));
            repo.ApplicationUnderTest.lbl_BusquedaDeCodigosDeProductorInfo.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_CodProductorBuscar' at Center.", repo.ApplicationUnderTest.txt_CodProductorBuscarInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.txt_CodProductorBuscar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PASS' with focus on 'ApplicationUnderTest.txt_CodProductorBuscar'.", repo.ApplicationUnderTest.txt_CodProductorBuscarInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.txt_CodProductorBuscar.PressKeys(PASS);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_Buscar' at Center.", repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_BuscarInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Creacion_PlanEnlatado_Autonomia.bttn_Buscar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(10));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.tag_PASS' at Center.", repo.ApplicationUnderTest.tag_PASSInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.tag_PASS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'ApplicationUnderTest.txt_CodigoProductorDetalle'", repo.ApplicationUnderTest.txt_CodigoProductorDetalleInfo, new ActionTimeout(15000), new RecordItemIndex(12));
            repo.ApplicationUnderTest.txt_CodigoProductorDetalleInfo.WaitForExists(15000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
