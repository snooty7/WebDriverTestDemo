﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();

driver.Url = "https://wikipedia.org";

var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();
searchField.SendKeys("QA");
searchField.SendKeys(Keys.Enter);
//driver.Quit();
