﻿/*using NUnit.Framework;
using Altom.AltUnityDriver;*/
using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Threading;
using Altom.AltUnityDriver;


namespace Editor.TestUnderDogPoker.Pages
{

    public class UtilityPage
    {
        /*  public AltUnityDriver AltUnityDriver;
          //Before any test it connects with the socket
          [OneTimeSetUp]
          public void SetUp()
          {
              AltUnityDriver =new AltUnityDriver();
          }

          //At the end of the test closes the connection with the socket
          [OneTimeTearDown]
          public void TearDown()
          {
              AltUnityDriver.Stop();
          }


          public void Test()
          {
          //Here you can write the test
          }*/





        private AltUnityDriver altUnityDriver;

        public void LoadLevel(String ScreenName)
        {
            string name = ScreenName;
            altUnityDriver.LoadScene(name, true);
        }

        public void TestGetCurrentScene(String CurrentScreen)
        {

            String name = CurrentScreen;
            Assert.AreEqual(name, altUnityDriver.GetCurrentScene());

        }


        public void TestFindElement(String Element)
        {

            string name = Element;
            var altElement = altUnityDriver.FindObject(By.NAME, name);
            Assert.NotNull(altElement);
            Assert.AreEqual(name, altElement.name);

        }



        public void TestFindElements(String Element)
        {

            string name = Element;
            var altElements = altUnityDriver.FindObjects(By.NAME, name);
            Assert.IsNotEmpty(altElements);
            Assert.AreEqual(altElements[0].name, name);

        }


        public void TestFindElementWhereNameContains(String SubText)
        {

            string name = SubText;
            var altElement = altUnityDriver.FindObject(By.PATH, "//*[contains(@name," + name + ")]");

            Assert.NotNull(altElement);
            Assert.True(altElement.name.Contains(name));

        }

        public void TestFindElementsWhereNameContains(String SubText)
        {
            string name = SubText;
            var altElements = altUnityDriver.FindObjects(By.PATH, "//*[contains(@name," + name + ")]");
            Assert.IsNotEmpty(altElements);
            Assert.True(altElements[0].name.Contains(name));
        }



        public void TestWaitForExistingElement()
        {
            const string name = "Capsule";
            var timeStart = DateTime.Now;
            var altElement = altUnityDriver.WaitForObject(By.NAME, name);
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.name, name);
        }

        public void TestWaitForExistingDisabledElement()
        {
            const string name = "Cube";
            var timeStart = DateTime.Now;
            var altElement = altUnityDriver.WaitForObject(By.NAME, name, enabled: false);
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.name, name);
        }




        public void TestWaitForCurrentSceneToBe()
        {
            const string name = "Scene 1 AltUnityDriverTestScene";
            var timeStart = DateTime.Now;
            var currentScene = altUnityDriver.WaitForCurrentSceneToBe(name);
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(currentScene);
            Assert.AreEqual("Scene 1 AltUnityDriverTestScene", currentScene);
        }




        public void TestWaitForExistingElementWhereNameContains()
        {
            const string name = "Dir";
            var timeStart = DateTime.Now;
            var altElement = altUnityDriver.WaitForObject(By.PATH, "//*[contains(@name," + name + ")]");
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.name, "Directional Light");
        }



        [Obsolete]
        public void TestWaitForElementWithText()
        {
            const string name = "CapsuleInfo";
            string text = altUnityDriver.FindObject(By.NAME, name).GetText();
            var timeStart = DateTime.Now;
            var altElement = altUnityDriver.WaitForObjectWithText(By.NAME, name, text);
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.GetText(), text);
        }


        public void TestSetTextForElement()
        {
            const string name = "InputField";
            const string text = "InputFieldTest";
            var input = altUnityDriver.FindObject(By.NAME, name).SetText(text);
            Assert.NotNull(input);
            Assert.AreEqual(input.GetText(), text);
        }


        public void TestFindObjectByComponent()
        {
            Thread.Sleep(1000);
            const string componentName = "AltUnityRunner";
            var altElement = altUnityDriver.FindObject(By.COMPONENT, componentName);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.name, "AltUnityRunnerPrefab");
        }


        public void TestFindObjectByComponentWithNamespace()
        {
            Thread.Sleep(1000);
            const string componentName = "AltUnityTester.AltUnityDriver.AltUnityRunner";
            var altElement = altUnityDriver.FindObject(By.COMPONENT, componentName);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.name, "AltUnityRunnerPrefab");
        }


        public void TestFindObjectByComponent2()
        {
            var altElement = altUnityDriver.FindObject(By.COMPONENT, "AltUnityExampleScriptCapsule");
            Assert.True(altElement.name.Equals("Capsule"));
        }

        public void TestFindObjectsByComponent()
        {
            var a = altUnityDriver.FindObjects(By.COMPONENT, "MeshFilter");
            Assert.AreEqual(3, a.Count);
        }


        public void TestGetComponentProperty()
        {
            Thread.Sleep(1000);
            const string componentName = "AltUnityRunner";
            const string propertyName = "SocketPortNumber";
            var altElement = altUnityDriver.FindObject(By.NAME, "AltUnityRunnerPrefab");
            Assert.NotNull(altElement);
            var propertyValue = altElement.GetComponentProperty(componentName, propertyName);
            Assert.AreEqual(propertyValue, "13000");
        }


        public void TestGetNonExistingComponentProperty()
        {
            Thread.Sleep(1000);
            const string componentName = "AltUnityRunner";
            const string propertyName = "socketPort";
            var altElement = altUnityDriver.FindObject(By.NAME, "AltUnityRunnerPrefab");
            Assert.NotNull(altElement);
            try
            {
                altElement.GetComponentProperty(componentName, propertyName);
                Assert.Fail();
            }
            catch (PropertyNotFoundException exception)
            {
                Assert.AreEqual(exception.Message, "error:propertyNotFound");
            }

        }

        public void TestGetComponentPropertyArray()
        {
            const string componentName = "AltUnityExampleScriptCapsule";
            const string propertyName = "arrayOfInts";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            Assert.NotNull(altElement);
            var propertyValue = altElement.GetComponentProperty(componentName, propertyName);
            Assert.AreEqual("[1,2,3]", propertyValue);
        }

#if !UNITY_IOS

        public void TestGetComponentPropertyUnityEngine()
        {
            const string componentName = "UnityEngine.CapsuleCollider";
            const string propertyName = "isTrigger";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            Assert.NotNull(altElement);
            var propertyValue = altElement.GetComponentProperty(componentName, propertyName);
            Assert.AreEqual("false", propertyValue);
        }
#endif


        public void TestSetComponentProperty()
        {
            const string componentName = "AltUnityExampleScriptCapsule";
            const string propertyName = "stringToSetFromTests";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            Assert.NotNull(altElement);
            var propertyValue = altElement.SetComponentProperty(componentName, propertyName, "2");
            Assert.AreEqual("valueSet", propertyValue);
            propertyValue = altElement.GetComponentProperty(componentName, propertyName);
            Assert.AreEqual("2", propertyValue);
        }


        public void TestSetNonExistingComponentProperty()
        {
            const string componentName = "Capsulee";
            const string propertyName = "stringToSetFromTests";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            Assert.NotNull(altElement);
            try
            {
                altElement.SetComponentProperty(componentName, propertyName, "2");
                Assert.Fail();
            }
            catch (Altom.AltUnityDriver.ComponentNotFoundException exception)
            {
                Assert.AreEqual(exception.Message, "error:componentNotFound");
            }
        }


        public void TestCallMethodWithNoParameters()
        {
            const string componentName = "AltUnityExampleScriptCapsule";
            const string methodName = "UIButtonClicked";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            var data = altElement.CallComponentMethod(componentName, methodName, "");
            Assert.AreEqual("null", data);
        }


        public void TestCallMethodWithParameters()
        {
            const string componentName = "AltUnityExampleScriptCapsule";
            const string methodName = "Jump";
            const string parameters = "New Text";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            var data = altElement.CallComponentMethod(componentName, methodName, parameters);
            Assert.AreEqual("null", data);
        }


        public void TestCallMethodWithManyParameters()
        {
            const string componentName = "AltUnityExampleScriptCapsule";
            const string methodName = "TestMethodWithManyParameters";
            const string parameters = "1?stringparam?0.5?[1,2,3]";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            var data = altElement.CallComponentMethod(componentName, methodName, parameters);
            Assert.AreEqual("null", data);
        }


        public void TestCallMethodWithIncorrectNumberOfParameters()
        {
            /* const string componentName = "AltUnityExampleScriptCapsule";
             const string methodName = "TestMethodWithManyParameters";
             const string parameters = "1?stringparam?[1,2,3]";
             var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
             try
             {
                 altElement.CallComponentMethod(componentName, methodName, parameters);
                 Assert.Fail();
             }
             catch (IncorrectNumberOfParametersException exception)
             {
                 Assert.AreEqual(exception.Message, "error:incorrectNumberOfParameters");
             }*/

        }


        public void TestCallMethodWithIncorrectTypeOfParameters()
        {
            const string componentName = "AltUnityExampleScriptCapsule";
            const string methodName = "TestMethodWithManyParameters";
            const string parameters = "a?stringparam?[1,2,3]";
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            try
            {
                altElement.CallComponentMethod(componentName, methodName, parameters);
                Assert.Fail();
            }
            catch (Altom.AltUnityDriver.AltUnityException exception)
            {
                Assert.AreEqual("error:incorrectNumberOfParameters", exception.Message);
            }
        }


        public void TestSetKeyInt()
        {
            altUnityDriver.DeletePlayerPref();
            altUnityDriver.SetKeyPlayerPref("test", 1);
            var val = altUnityDriver.GetIntKeyPlayerPref("test");
            Assert.AreEqual(1, val);
        }

        public void TestSetKeyFloat()
        {
            altUnityDriver.DeletePlayerPref();
            altUnityDriver.SetKeyPlayerPref("test", 1f);
            var val = altUnityDriver.GetFloatKeyPlayerPref("test");
            Assert.AreEqual(1f, val);
        }


        public void TestSetKeyString()
        {
            altUnityDriver.DeletePlayerPref();
            altUnityDriver.SetKeyPlayerPref("test", "test");
            var val = altUnityDriver.GetStringKeyPlayerPref("test");
            Assert.AreEqual("test", val);
        }


        public void TestDeleteKey()
        {
            altUnityDriver.DeletePlayerPref();
            altUnityDriver.SetKeyPlayerPref("test", 1);
            var val = altUnityDriver.GetIntKeyPlayerPref("test");
            Assert.AreEqual(1, val);
            altUnityDriver.DeleteKeyPlayerPref("test");
            try
            {
                altUnityDriver.GetIntKeyPlayerPref("test");
                Assert.Fail();
            }
            catch (NotFoundException exception)
            {
                Assert.AreEqual("error:notFound", exception.Message);
            }

        }


        public void TestDifferentCamera()
        {
            var altButton = altUnityDriver.FindObject(By.NAME, "Button", By.NAME, "Main Camera");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule", By.NAME, "Main Camera");
            var altElement2 = altUnityDriver.FindObject(By.NAME, "Capsule", By.NAME, "Camera");
            AltUnityVector2 pozOnScreenFromMainCamera = new AltUnityVector2(altElement.x, altElement.y);
            AltUnityVector2 pozOnScreenFromSecondaryCamera = new AltUnityVector2(altElement2.x, altElement2.y);

            Assert.AreNotEqual(pozOnScreenFromSecondaryCamera, pozOnScreenFromMainCamera);

        }


        public void TestFindNonExistentObject()
        {
            try
            {
                altUnityDriver.FindObject(By.NAME, "NonExistent");
                Assert.Fail();
            }
            catch (NotFoundException exception)
            {
                Assert.AreEqual(exception.Message, "error:notFound");
            }

        }


        public void TestFindNonExistentObjectByName()
        {
            try
            {
                altUnityDriver.FindObject(By.PATH, "//*[contains(@name,NonExistent)]");
                Assert.Fail();
            }
            catch (NotFoundException exception)
            {
                Assert.AreEqual(exception.Message, "error:notFound");
            }

        }


        public void TestButtonClickWithSwipe()
        {
            var button = altUnityDriver.FindObject(By.NAME, "UIButton");
            AltUnityVector2 vector2 = new AltUnityVector2(button.x, button.y);
            altUnityDriver.HoldButtonAndWait(vector2, 1);
            var capsuleInfo = altUnityDriver.FindObject(By.NAME, "CapsuleInfo");
            Thread.Sleep(1400);
            var text = capsuleInfo.GetText();
            Assert.AreEqual(text, "UIButton clicked to jump capsule!");
        }

        [Obsolete]
        public void TestClickElement(string Element)
        {
            string name = Element;
            var altElement = altUnityDriver.FindObject(By.NAME, name).Tap();
            Assert.AreEqual(name, altElement.name);
            altUnityDriver.WaitForObjectWithText(By.NAME, Element, Element+" was clicked to jump!");
        }


        public void TestClickScreen()
        {
            const string name = "UIButton";
            var altElement2 = altUnityDriver.FindObject(By.NAME, name);
            var altElement = altUnityDriver.TapScreen(altElement2.x, altElement2.y);
            Assert.AreEqual(name, altElement.name);
            altUnityDriver.WaitForObjectWithText(By.NAME, "CapsuleInfo", "UIButton clicked to jump capsule!");
        }


        public void TestWaitForNonExistingObject()
        {
            try
            {
                altUnityDriver.WaitForObject(By.NAME, "dlkasldkas", timeout: 1, interval: 1);
                Assert.Fail();
            }
            catch (WaitTimeOutException exception)
            {
                Assert.AreEqual("Element dlkasldkas not loaded after 1 seconds", exception.Message);
            }
        }

        public void TestWaitForObjectToNotExist()
        {
            altUnityDriver.WaitForObjectNotBePresent(By.NAME, "ObjectDestroyedIn5Secs");
            altUnityDriver.WaitForObjectNotBePresent(By.NAME, "Capsulee", timeout: 1, interval: 0.5f);
        }


        public void TestWaitForObjectToNotExistFail()
        {
            try
            {
                altUnityDriver.WaitForObjectNotBePresent(By.NAME, "Capsule", timeout: 1, interval: 0.5f);
                Assert.Fail();
            }
            catch (WaitTimeOutException exception)
            {
                Assert.AreEqual("Element //Capsule still found after 1 seconds", exception.Message);
            }
        }


        public void TestWaitForObjectWithTextWrongText()
        {
            try
            {
                altUnityDriver.WaitForObjectWithText(By.NAME, "CapsuleInfo", "aaaaa", timeout: 1);
                Assert.Fail();
            }
            catch (WaitTimeOutException exception)
            {
                Assert.AreEqual("Element with text: aaaaa not loaded after 1 seconds", exception.Message);
            }
        }


        public void TestWaitForCurrrentSceneToBeANonExistingScene()
        {
            const string name = "AltUnityDriverTestScenee";
            try
            {
                altUnityDriver.WaitForCurrentSceneToBe(name, 1);
                Assert.Fail();
            }
            catch (WaitTimeOutException exception)
            {
                Assert.AreEqual("Scene AltUnityDriverTestScenee not loaded after 1 seconds", exception.Message);
            }

        }



        public void TestWaitForNonExistingElementWhereNameContains()
        {
            const string name = "xyz";
            try
            {
                altUnityDriver.WaitForObject(By.PATH, "//*[contains(@name," + name + ")]", timeout: 1);
                Assert.Fail();
            }
            catch (WaitTimeOutException exception)
            {
                Assert.AreEqual("Element //*[contains(@name,xyz)] not loaded after 1 seconds", exception.Message);
            }

        }


        [Obsolete]
        public void TestCallStaticMethod()
        {

            altUnityDriver.CallStaticMethods("UnityEngine.PlayerPrefs", "SetInt", "Test?1");
            int a = Int32.Parse(altUnityDriver.CallStaticMethods("UnityEngine.PlayerPrefs", "GetInt", "Test?2"));
            Assert.AreEqual(1, a);

        }

        public void TestCallMethodWithMultipleDefinitions()
        {

            AltUnityObject capsule = altUnityDriver.FindObject(By.NAME, "Capsule");
            capsule.CallComponentMethod("AltUnityExampleScriptCapsule", "Test", "2", "System.Int32");
            AltUnityObject capsuleInfo = altUnityDriver.FindObject(By.NAME, "CapsuleInfo");
            Assert.AreEqual("6", capsuleInfo.GetText());
        }

        public void TestCallMethodWithAssembly()
        {
            AltUnityObject capsule = altUnityDriver.FindObject(By.NAME, "Capsule");
            var initialRotation = capsule.GetComponentProperty("UnityEngine.Transform", "rotation");
            capsule.CallComponentMethod("UnityEngine.Transform", "Rotate", "10?10?10", "System.Single?System.Single?System.Single", "UnityEngine.CoreModule");
            AltUnityObject capsuleAfterRotation = altUnityDriver.FindObject(By.NAME, "Capsule");
            var finalRotation = capsuleAfterRotation.GetComponentProperty("UnityEngine.Transform", "rotation");
            Assert.AreNotEqual(initialRotation, finalRotation);
        }


        public void TestGetAllComponents()
        {
            List<AltUnityComponent> components = altUnityDriver.FindObject(By.NAME, "Canvas").GetAllComponents();
            Assert.AreEqual(4, components.Count);
            Assert.AreEqual("UnityEngine.RectTransform", components[0].componentName);
            Assert.AreEqual("UnityEngine.CoreModule", components[0].assemblyName);
        }

        public void TestGetAllMethodsFromClass()
        {
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            var component2 = altElement.GetAllComponents().First(component => component.componentName.Equals("AltUnityExampleScriptCapsule"));
            List<String> methods = altElement.GetAllMethods(component2, AltUnityMethodSelection.CLASSMETHODS);
            Assert.IsTrue(methods.Contains("Void UIButtonClicked()"));
            Assert.IsFalse(methods.Contains("Void CancelInvoke(System.String)"));
        }

        public void TestGetAllMethodsFromInherited()
        {
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            var component2 = altElement.GetAllComponents().First(component => component.componentName.Equals("AltUnityExampleScriptCapsule"));
            List<String> methods = altElement.GetAllMethods(component2, AltUnityMethodSelection.INHERITEDMETHODS);
            Assert.IsTrue(methods.Contains("Void CancelInvoke(System.String)"));
            Assert.IsFalse(methods.Contains("Void UIButtonClicked()"));
        }

        public void TestGetAllMethods()
        {
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            var component2 = altElement.GetAllComponents().First(component => component.componentName.Equals("AltUnityExampleScriptCapsule"));
            List<String> methods = altElement.GetAllMethods(component2, AltUnityMethodSelection.ALLMETHODS);
            Assert.IsTrue(methods.Contains("Void CancelInvoke(System.String)"));
            Assert.IsTrue(methods.Contains("Void UIButtonClicked()"));
        }


        public void TestGetAllFields()
        {
            var altElement = altUnityDriver.FindObject(By.NAME, "Capsule");
            var componentList = altElement.GetAllComponents();
            var component = componentList.First(componenta =>
                componenta.componentName.Equals("AltUnityExampleScriptCapsule") && componenta.assemblyName.Equals("Assembly-CSharp"));
            List<AltUnityProperty> properties = altElement.GetAllProperties(component);
            AltUnityProperty field = properties.First(prop => prop.name.Equals("stringToSetFromTests"));
            Assert.NotNull(field);
            Assert.AreEqual(field.value, "intialValue");
        }

        public void TestFindObjectByTag()
        {
            var altElement = altUnityDriver.FindObject(By.TAG, "plane");
            Assert.True(altElement.name.Equals("Plane"));
        }

        public void TestFindObjectByLayer()
        {
            var altElement = altUnityDriver.FindObject(By.LAYER, "Water");
            Assert.True(altElement.name.Equals("Capsule"));
        }

        public void TestFindObjectByUnityComponent()
        {
            var altElement = altUnityDriver.FindObject(By.COMPONENT, "CapsuleCollider");
            Assert.True(altElement.name.Equals("Capsule"));
        }


        public void TestFindChild()
        {
            var altElement = altUnityDriver.FindObject(By.PATH, "//UIButton/*");
            Assert.True(altElement.name.Equals("Text"));
        }

        public void TestFindingDifferentObjects()
        {
            var altElement = altUnityDriver.FindObject(By.PATH, "//*[contains(@name,Cub)]", enabled: false);
            Assert.True(altElement.name.Equals("Cube"));

            altElement = altUnityDriver.FindObject(By.PATH, "//RotateMainCameraButton/../*[contains(@name,Seconda)]/Text");
            Assert.True(altElement.name.Equals("Text"));

            altElement = altUnityDriver.FindObject(By.PATH, "//*[@component=BoxCollider]", enabled: false);
            Assert.True(altElement.name.Equals("Cube"));


        }
        //
        //public void TestFindObjectWithDifferentCameras()
        //{
        //    var changeCameraButton = altUnityDriver.FindObject(By.NAME, "Button");
        //    changeCameraButton.Tap().Tap();
        //    var altElement1 = altUnityDriver.FindObject(By.NAME, "Capsule", cameraName: "Main Camera", enabled: false);
        //    var altElement2 = altUnityDriver.FindObject(By.NAME, "Capsule", cameraName: "Camera", enabled: false);
        //    Assert.AreNotEqual(altElement1.y, altElement2.y);
        //    Assert.AreNotEqual(altElement1.x, altElement2.x);
        //}


        public void TestFindObjectsByTag()
        {
            var altElements = altUnityDriver.FindObjects(By.TAG, "plane");
            Assert.AreEqual(2, altElements.Count);
            foreach (var altElement in altElements)
            {
                Assert.AreEqual("Plane", altElement.name);
            }
        }


        public void TestFindObjectsByLayer()
        {
            var altElements = altUnityDriver.FindObjects(By.LAYER, "Default");
            Assert.AreEqual(12, altElements.Count);
        }

        public void TestFindObjectsByContainName()
        {
            var altElements = altUnityDriver.FindObjects(By.PATH, "//*[contains(@name,Ca)]");
            foreach (var altElement in altElements)
            {
                UnityEngine.Debug.Log(altElement.name);
                Assert.True(altElement.name.Contains("Ca"));
            }
            Assert.AreEqual(9, altElements.Count);

        }



        public void TestInactiveObject()
        {
            AltUnityObject cube = altUnityDriver.FindObject(By.NAME, "Cube", enabled: false);
            Assert.AreEqual(false, cube.enabled);

        }


        public void TestGetAllScenes()
        {
            var scenes = altUnityDriver.GetAllScenes();
            Assert.AreEqual(6, scenes.Count);
            Assert.AreEqual("Scene 1 AltUnityDriverTestScene", scenes[0]);
        }

        public void TestTapScreenWhereThereIsNoObjects()
        {
            var counterButton = altUnityDriver.FindObject(By.NAME, "ButtonCounter");
            AltUnityObject altObject = altUnityDriver.TapScreen(1, counterButton.y + 100);
            Assert.AreEqual(null, altObject);
        }


        public void TestSetTimeScale()
        {
            altUnityDriver.SetTimeScale(0.1f);
            Thread.Sleep(1000);
            var timeScaleFromGame = altUnityDriver.GetTimeScale();
            Assert.AreEqual(0.1f, timeScaleFromGame);
            altUnityDriver.SetTimeScale(1);
        }


        public void TestWaitForObjectWhichContains()
        {
            var altElement = altUnityDriver.WaitForObjectWhichContains(By.NAME, "Canva");
            Assert.AreEqual("Canvas", altElement.name);

        }

        public void TestFindObjectWhichContains()
        {
            var altElement = altUnityDriver.FindObjectWhichContains(By.NAME, "Event");
            Assert.AreEqual("EventSystem", altElement.name);
        }

        public void TestFindWithFindObjectWhichContainsNotExistingObject()
        {
            try
            {
                var altElement = altUnityDriver.FindObjectWhichContains(By.NAME, "EventNonExisting");
                Assert.Fail("Error should have been thrown");
            }
            catch (NotFoundException exception)
            {
                Assert.AreEqual(exception.Message, "error:notFound");
            }
        }

        public void TestGetAllCameras()
        {
            var cameras = altUnityDriver.GetAllCameras();
            Assert.AreEqual(2, cameras.Count);
        }


        public void TestFindObjectScene1()
        {
            var altElements = altUnityDriver.FindObjects(By.PATH, "//Canvas/*/Text");
            Assert.AreEqual(7, altElements.Count);
        }


        public void TestFindObjectScene6()
        {
            altUnityDriver.LoadScene("Scene6");

            Thread.Sleep(1000);
            altUnityDriver.WaitForCurrentSceneToBe("Scene6");
            var altElements = altUnityDriver.FindObjects(By.PATH, "//Canvas/*/Text");
            Assert.AreEqual(3, altElements.Count);
            altElements = altUnityDriver.FindObjects(By.PATH, "/*/*/Text");
            Assert.AreEqual(3, altElements.Count);
            altElements = altUnityDriver.FindObjects(By.PATH, "/*/Text");
            Assert.AreEqual(1, altElements.Count);
            altElements = altUnityDriver.FindObjects(By.PATH, "//Text");
            Assert.AreEqual(5, altElements.Count);
            altElements = altUnityDriver.FindObjects(By.PATH, "//Canvas/*//Text");
            Assert.AreEqual(4, altElements.Count);
        }

        public void TestGetScreenshot()
        {
            var path = "testC.png";
            altUnityDriver.GetPNGScreenshot(path);
            FileAssert.Exists(path);
        }

        public void TestGetChineseLetters()
        {
            var text = altUnityDriver.FindObject(By.NAME, "ChineseLetters").GetText();
            Assert.AreEqual("哦伊娜哦", text);
        }

        public void TestNonEnglishText()
        {
            var text = altUnityDriver.FindObject(By.NAME, "NonEnglishText").GetText();
            Assert.AreEqual("BJÖRN'S PASS", text);
        }

        public void TestDoubleTap()
        {
            var counterButton = altUnityDriver.FindObject(By.NAME, "ButtonCounter");
            var counterButtonText = altUnityDriver.FindObject(By.NAME, "ButtonCounter/Text");
            counterButton.DoubleTap();
            Thread.Sleep(500);
            Assert.AreEqual("2", counterButtonText.GetText());
        }

        public void TestCustomTap()
        {
            var counterButton = altUnityDriver.FindObject(By.NAME, "ButtonCounter");
            var counterButtonText = altUnityDriver.FindObject(By.NAME, "ButtonCounter/Text");
            altUnityDriver.TapCustom(counterButton.x, counterButton.y, 4);
            Thread.Sleep(1000);
            Assert.AreEqual("4", counterButtonText.GetText());
        }
        public void TestGet3DObjectFromScreenshot()
        {
            var capsule = altUnityDriver.FindObject(By.NAME, "Capsule");
            AltUnityObject altUnityObject;
            altUnityDriver.GetScreenshot(new AltUnityVector2(capsule.x, capsule.y), new AltUnityColor(1, 0, 0, 1), 1, out altUnityObject, new AltUnityVector2(1920, 1080));
            Assert.AreEqual("Capsule", altUnityObject.name);
        }


        public void TestGetUIObjectFromScreenshot()
        {
            var capsuleInfo = altUnityDriver.FindObject(By.NAME, "CapsuleInfo");
            AltUnityObject altUnityObject;
            altUnityDriver.GetScreenshot(new AltUnityVector2(capsuleInfo.x, capsuleInfo.y), new AltUnityColor(1, 0, 0, 1), 1, out altUnityObject, new AltUnityVector2(1920, 1080));
            Assert.AreEqual("CapsuleInfo", altUnityObject.name);
        }

        public void TestObjectFromScreenshot()
        {
            var icon = altUnityDriver.FindObject(By.NAME, "Icon");
            AltUnityVector2 offscreenCoordinates = new AltUnityVector2(icon.x + 400, icon.y);
            AltUnityObject altUnityObject;
            altUnityDriver.GetScreenshot(offscreenCoordinates, new AltUnityColor(1, 0, 0, 1), 1, out altUnityObject, new AltUnityVector2(1920, 1080));
            Assert.IsNull(altUnityObject);
        }


        public void TestPressNextSceneButtton()
        {
            var initialScene = altUnityDriver.GetCurrentScene();
            altUnityDriver.FindObject(By.NAME, "NextScene").Tap();
            var currentScene = altUnityDriver.GetCurrentScene();
            Assert.AreNotEqual(initialScene, currentScene);
        }

        public void TestForSetText()
        {
            var text = altUnityDriver.FindObject(By.NAME, "NonEnglishText");
            var originalText = text.GetText();
            var afterText = text.SetText("ModifiedText").GetText();
            Assert.AreNotEqual(originalText, afterText);
        }

        public void TestFindParentUsingPath()
        {
            var parent = altUnityDriver.FindObject(By.PATH, "//CapsuleInfo/..");
            Assert.AreEqual("Canvas", parent.name);
        }

        public void TestFindObjectWithCameraId()
        {
            var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var camera = altUnityDriver.FindObject(By.PATH, "//Camera");
            var altElement = altUnityDriver.FindObject(By.COMPONENT, "CapsuleCollider", By.ID, camera.id.ToString());
            Assert.True(altElement.name.Equals("Capsule"));
            var camera2 = altUnityDriver.FindObject(By.PATH, "//Main Camera");
            var altElement2 = altUnityDriver.FindObject(By.COMPONENT, "CapsuleCollider", By.ID, camera2.id.ToString());
            Assert.AreNotEqual(altElement.getScreenPosition(), altElement2.getScreenPosition());
        }


        public void TestWaitForObjectWithCameraId()
        {
            var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var camera = altUnityDriver.FindObject(By.PATH, "//Camera");
            var altElement = altUnityDriver.WaitForObject(By.COMPONENT, "CapsuleCollider", By.ID, camera.id.ToString());
            Assert.True(altElement.name.Equals("Capsule"));
            var camera2 = altUnityDriver.FindObject(By.PATH, "//Main Camera");
            var altElement2 = altUnityDriver.WaitForObject(By.COMPONENT, "CapsuleCollider", By.ID, camera2.id.ToString());
            Assert.AreNotEqual(altElement.getScreenPosition(), altElement2.getScreenPosition());
        }


        public void TestFindObjectsWithCameraId()
        {
            var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var camera = altUnityDriver.FindObject(By.PATH, "//Camera");
            var altElement = altUnityDriver.FindObjects(By.NAME, "Plane", By.ID, camera.id.ToString());
            Assert.True(altElement[0].name.Equals("Plane"));
            var camera2 = altUnityDriver.FindObject(By.PATH, "//Main Camera");
            var altElement2 = altUnityDriver.FindObjects(By.NAME, "Plane", By.ID, camera2.id.ToString());
            Assert.AreNotEqual(altElement[0].getScreenPosition(), altElement2[0].getScreenPosition());
        }


        public void TestWaitForObjectNotBePresentWithCameraId()
        {
            var camera2 = altUnityDriver.FindObject(By.PATH, "//Main Camera");
            altUnityDriver.WaitForObjectNotBePresent(By.NAME, "ObjectDestroyedIn5Secs", By.ID, camera2.id.ToString());

            var allObjectsInTheScene = altUnityDriver.GetAllElements();
            Assert.IsTrue(!allObjectsInTheScene.Any(obj => obj.name.Equals("ObjectDestroyedIn5Secs")));
        }


        public void TestWaitForElementWithTextWithCameraId()
        {
            const string name = "CapsuleInfo";
            string text = altUnityDriver.FindObject(By.NAME, name).GetText();
            var timeStart = DateTime.Now;
            var camera2 = altUnityDriver.FindObject(By.PATH, "//Main Camera");
            var altElement = altUnityDriver.WaitForObjectWithText(By.NAME, name, text, By.ID, camera2.id.ToString());
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.GetText(), text);
        }


        public void TestWaitForObjectWhichContainsWithCameraId()
        {
            var camera2 = altUnityDriver.FindObject(By.PATH, "//Main Camera");
            var altElement = altUnityDriver.WaitForObjectWhichContains(By.NAME, "Canva", By.ID, camera2.id.ToString());
            Assert.AreEqual("Canvas", altElement.name);

        }



        public void TestFindObjectWithTag()
        {
            var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var altElement = altUnityDriver.FindObject(By.COMPONENT, "CapsuleCollider", By.TAG, "MainCamera");
            Assert.True(altElement.name.Equals("Capsule"));
            var altElement2 = altUnityDriver.FindObject(By.COMPONENT, "CapsuleCollider", By.TAG, "Untagged");
            Assert.AreNotEqual(altElement.getScreenPosition(), altElement2.getScreenPosition());
        }


        public void TestWaitForObjectWithTag()
        {
            var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var altElement = altUnityDriver.WaitForObject(By.COMPONENT, "CapsuleCollider", By.TAG, "MainCamera");
            Assert.True(altElement.name.Equals("Capsule"));
            var altElement2 = altUnityDriver.WaitForObject(By.COMPONENT, "CapsuleCollider", By.TAG, "Untagged");
            Assert.AreNotEqual(altElement.getScreenPosition(), altElement2.getScreenPosition());
        }


        [Obsolete]
        public void TestFindObjectsWithTag()
        {
            var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var altElement = altUnityDriver.FindObjects(By.NAME, "Capsule", By.TAG, "MainCamera");
            Assert.True(altElement[0].name.Equals("Capsule"));
            var altElement2 = altUnityDriver.FindObjects(By.NAME, "Capsule", By.TAG, "Untagged");
            Assert.AreNotEqual(altElement[0].getScreenPosition(), altElement2[0].getScreenPosition());
        }


        public void TestWaitForObjectNotBePresentWithTag()
        {
            var camera2 = altUnityDriver.FindObject(By.PATH, "//Main Camera");
            altUnityDriver.WaitForObjectNotBePresent(By.NAME, "ObjectDestroyedIn5Secs", By.TAG, "MainCamera");

            var allObjectsInTheScene = altUnityDriver.GetAllElements();
            Assert.IsTrue(!allObjectsInTheScene.Any(obj => obj.name.Equals("ObjectDestroyedIn5Secs")));
        }


        public void TestWaitForElementWithTextWithTag()
        {
            const string name = "CapsuleInfo";
            string text = altUnityDriver.FindObject(By.NAME, name).GetText();
            var timeStart = DateTime.Now;
            var altElement = altUnityDriver.WaitForObjectWithText(By.NAME, name, text, By.TAG, "MainCamera");
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.GetText(), text);
        }


        public void TestWaitForObjectWhichContainsWithTag()
        {
            var altElement = altUnityDriver.WaitForObjectWhichContains(By.NAME, "Canva", By.TAG, "MainCamera");
            Assert.AreEqual("Canvas", altElement.name);

        }

        public void TestAcceleration()
        {
            var capsule = altUnityDriver.FindObject(By.NAME, "Capsule");
            var initialWorldCoordinates = capsule.getWorldPosition();
            altUnityDriver.Tilt(new AltUnityVector3(1, 1, 1), 1);
            Thread.Sleep(1000);
            capsule = altUnityDriver.FindObject(By.NAME, "Capsule");
            var afterTiltCoordinates = capsule.getWorldPosition();
            Assert.AreNotEqual(initialWorldCoordinates, afterTiltCoordinates);
        }

        public void TestAccelerationAndWait()
        {
            var capsule = altUnityDriver.FindObject(By.NAME, "Capsule");
            var initialWorldCoordinates = capsule.getWorldPosition();
            altUnityDriver.TiltAndWait(new AltUnityVector3(1, 1, 1), 1);
            Thread.Sleep(1000);
            capsule = altUnityDriver.FindObject(By.NAME, "Capsule");
            var afterTiltCoordinates = capsule.getWorldPosition();
            Assert.AreNotEqual(initialWorldCoordinates, afterTiltCoordinates);
        }


        public void TestFindObjectWithObsoleteCameraMethod()
        {
            /*var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var altElement = altUnityDriver.FindObject(By.COMPONENT, "CapsuleCollider", "Camera");
            Assert.True(altElement.name.Equals("Capsule"));
            var altElement2 = altUnityDriver.FindObject(By.COMPONENT, "CapsuleCollider", "Main Camera");
            Assert.AreNotEqual(altElement.getScreenPosition(), altElement2.getScreenPosition());*/
        }


        [Obsolete]
        public void TestWaitForObjectWithObsoleteCameraMethod()
        {
            /*var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
            altButton.ClickEvent();
            altButton.ClickEvent();
            var altElement = altUnityDriver.WaitForObject(By.COMPONENT, "CapsuleCollider", "Camera");
            Assert.True(altElement.name.Equals("Capsule"));
            var altElement2 = altUnityDriver.WaitForObject(By.COMPONENT, "CapsuleCollider", "Main Camera");
            Assert.AreNotEqual(altElement.getScreenPosition(), altElement2.getScreenPosition());*/
        }


        public void TestFindObjectsWithObsoleteCameraMethod()
        {
            /* var altButton = altUnityDriver.FindObject(By.PATH, "//Button");
             altButton.ClickEvent();
             altButton.ClickEvent();
             var altElement = altUnityDriver.FindObjects(By.NAME, "Plane", "Camera");
             Assert.True(altElement[0].name.Equals("Plane"));
             var altElement2 = altUnityDriver.FindObjects(By.NAME, "Plane", "Main Camera");
             Assert.AreNotEqual(altElement[0].getScreenPosition(), altElement2[0].getScreenPosition());*/
        }


        public void TestWaitForObjectNotBePresentWithObsoleteCameraMethod()
        {
            /* altUnityDriver.WaitForObjectNotBePresent(By.NAME, "ObjectDestroyedIn5Secs", "Main Camera");

             var allObjectsInTheScene = altUnityDriver.GetAllElements();
             Assert.IsTrue(!allObjectsInTheScene.Any(obj => obj.name.Equals("ObjectDestroyedIn5Secs")));*/
        }


        public void TestWaitForElementWithTextWithObsoleteCameraMethod()
        {
            /*const string name = "CapsuleInfo";
            string text = altUnityDriver.FindObject(By.NAME, name).GetText();
            var timeStart = DateTime.Now;
            var altElement = altUnityDriver.WaitForObjectWithText(By.NAME, name, text, "Main Camera");
            var timeEnd = DateTime.Now;
            var time = timeEnd - timeStart;
            Assert.Less(time.TotalSeconds, 20);
            Assert.NotNull(altElement);
            Assert.AreEqual(altElement.GetText(), text);*/
        }


        public void TestWaitForObjectWhichContainsWithObsoleteCameraMethod()
        {
            /* var altElement = altUnityDriver.WaitForObjectWhichContains(By.NAME, "Canva", "Main Camera");
             Assert.AreEqual("Canvas", altElement.name);*/

        }

        public void TestLoadAdditiveScenes()
        {
            var initialNumberOfElements = altUnityDriver.GetAllElements();
            altUnityDriver.LoadScene("Scene 2 Draggable Panel", false);
            var finalNumberOfElements = altUnityDriver.GetAllElements();
            Assert.IsTrue(initialNumberOfElements.Count < finalNumberOfElements.Count);
            var scenes = altUnityDriver.GetAllLoadedScenes();
            Assert.IsTrue(scenes.Count == 2);
            altUnityDriver.LoadScene("Scene 2 Draggable Panel", true);
        }
    }

}


