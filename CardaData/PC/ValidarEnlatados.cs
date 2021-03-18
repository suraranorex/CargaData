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
    ///The ValidarEnlatados recording.
    /// </summary>
    [TestModule("342ffb26-18ee-421c-a492-22a0b9837ff7", ModuleType.Recording, 1)]
    public partial class ValidarEnlatados : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static ValidarEnlatados instance = new ValidarEnlatados();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidarEnlatados()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidarEnlatados Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_unidadNegocio' at Center.", repo.ApplicationUnderTest.txt_unidadNegocioInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.txt_unidadNegocio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'ApplicationUnderTest.txt_unidadNegocio'.", repo.ApplicationUnderTest.txt_unidadNegocioInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.txt_unidadNegocio.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Sura' with focus on 'ApplicationUnderTest.txt_unidadNegocio'.", repo.ApplicationUnderTest.txt_unidadNegocioInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.txt_unidadNegocio.PressKeys("Sura");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_PlanesEnlatados' at Center.", repo.ApplicationUnderTest.lbl_PlanesEnlatadosInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.lbl_PlanesEnlatados.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_CodAgenteEnlatado' at Center.", repo.ApplicationUnderTest.txt_CodAgenteEnlatadoInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.txt_CodAgenteEnlatado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'ApplicationUnderTest.txt_CodAgenteEnlatado'.", repo.ApplicationUnderTest.txt_CodAgenteEnlatadoInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.txt_CodAgenteEnlatado.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2344 - Sura Marketing (Latin America) S.A.' with focus on 'ApplicationUnderTest.txt_CodAgenteEnlatado'.", repo.ApplicationUnderTest.txt_CodAgenteEnlatadoInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.txt_CodAgenteEnlatado.PressKeys("2344 - Sura Marketing (Latin America) S.A.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_PlanesEnlatados' at Center.", repo.ApplicationUnderTest.lbl_PlanesEnlatadosInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.lbl_PlanesEnlatados.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.Btn_BuscarEnlatado' at Center.", repo.ApplicationUnderTest.Btn_BuscarEnlatadoInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Btn_BuscarEnlatado.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_BuscarEnlatado' at Center.", repo.ApplicationUnderTest.Btn_BuscarEnlatadoInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Btn_BuscarEnlatado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to exist. Associated repository item: 'ApplicationUnderTest.filaUnoEnlatados'", repo.ApplicationUnderTest.filaUnoEnlatadosInfo, new ActionTimeout(50000), new RecordItemIndex(11));
            repo.ApplicationUnderTest.filaUnoEnlatadosInfo.WaitForExists(50000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
