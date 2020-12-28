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

namespace CardaData.Generales.Login
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login recording.
    /// </summary>
    [TestModule("ff77de51-9c7d-40f7-a71e-98ce7096109f", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::CardaData.CardaDataRepository repository.
        /// </summary>
        public static global::CardaData.CardaDataRepository repo = global::CardaData.CardaDataRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            Usuario = "su";
            Contrasenia = "gw";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _Usuario;

        /// <summary>
        /// Gets or sets the value of variable Usuario.
        /// </summary>
        [TestVariable("e9835d8f-c8c8-444e-8564-b15ccdce9628")]
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        string _Contrasenia;

        /// <summary>
        /// Gets or sets the value of variable Contrasenia.
        /// </summary>
        [TestVariable("ceffe547-efb0-417f-9e67-a03ec36b6299")]
        public string Contrasenia
        {
            get { return _Contrasenia; }
            set { _Contrasenia = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$Usuario' on item 'ApplicationUnderTest.Login.txtbox_Usuario'.", repo.ApplicationUnderTest.Login.txtbox_UsuarioInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Login.txtbox_Usuario.Element.SetAttributeValue("TagValue", Usuario);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$Contrasenia' on item 'ApplicationUnderTest.Login.txtbox_Contrasenia'.", repo.ApplicationUnderTest.Login.txtbox_ContraseniaInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Login.txtbox_Contrasenia.Element.SetAttributeValue("TagValue", Contrasenia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Login.bttn_IniciarSesion' at 26;3.", repo.ApplicationUnderTest.Login.bttn_IniciarSesionInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Login.bttn_IniciarSesion.Click("26;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'ApplicationUnderTest.bttn_Configuracion1'", repo.ApplicationUnderTest.bttn_Configuracion1Info, new ActionTimeout(40000), new RecordItemIndex(3));
            repo.ApplicationUnderTest.bttn_Configuracion1Info.WaitForExists(40000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}