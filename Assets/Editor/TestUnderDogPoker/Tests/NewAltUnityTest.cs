﻿using NUnit.Framework;
using Altom.AltUnityDriver;
using System.Threading;
using UnityEngine;

public class NewAltUnityTest
{
    public AltUnityDriver altUnityDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altUnityDriver =new AltUnityDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        Thread.Sleep(2000);
        altUnityDriver.Stop();
    }

    [Test]
    public void Test()
    {
        //Here you can write the test

        altUnityDriver.LoadScene("Dashboard");
        Debug.Log("Loading Dashboard");



    }

}