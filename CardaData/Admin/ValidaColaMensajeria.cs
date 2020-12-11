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

namespace CardaData.Admin
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidaColaMensajeria recording.
    /// </summary>
    [TestModule("bdc643ff-1100-46ff-a1db-da26ca886474", ModuleType.Recording, 1)]
    public partial class ValidaColaMensajeria : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static ValidaColaMensajeria instance = new ValidaColaMensajeria();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidaColaMensajeria()
        {
            estado = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidaColaMensajeria Instance
        {
            get { return instance; }
        }

#region Variables

        string _estado;

        /// <summary>
        /// Gets or sets the value of variable estado.
        /// </summary>
        [TestVariable("9a375142-64ef-49f2-84f1-31311519a6c2")]
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MenuAdm' at CenterRight.", repo.ApplicationUnderTest.MenuAdmInfo, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.MenuAdm.Click(Location.CenterRight);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.SubmenuSupervision' at Center.", repo.ApplicationUnderTest.SubmenuSupervisionInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.SubmenuSupervision.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.SubMenuMensajes' at Center.", repo.ApplicationUnderTest.SubMenuMensajesInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SubMenuMensajes.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubMenuColasDeMensajes' at Center.", repo.ApplicationUnderTest.SubMenuColasDeMensajesInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.SubMenuColasDeMensajes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.Check_SistemaDeFacturacion'.", repo.ApplicationUnderTest.Check_SistemaDeFacturacionInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ApplicationUnderTest.Check_SistemaDeFacturacionInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.Check_SistemaDeFacturacion' and assigning its value to variable 'estado'.", repo.ApplicationUnderTest.Check_SistemaDeFacturacionInfo, new RecordItemIndex(5));
            estado = repo.ApplicationUnderTest.Check_SistemaDeFacturacion.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Cola de Sistema De facturación:", new RecordItemIndex(6));
            
            // Estado de Cola de Mensajeria SistemaDeFacturacion
            Report.Log(ReportLevel.Info, "User", estado, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
