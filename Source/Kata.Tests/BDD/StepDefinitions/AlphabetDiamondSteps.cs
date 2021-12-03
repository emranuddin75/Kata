using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using Kata.Core;
using Kata.Core.Diamond;
using TechTalk.SpecFlow;
using Xunit;

namespace Kata.Tests.BDD.StepDefinitions
{
    [Binding]
    public class AlphabetDiamondSteps
    {
        private readonly ScenarioContext scenarioContext;

        public AlphabetDiamondSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"Center Supplied Character Is Not a Letter")]
        public void GivenCenterSuppliedCharacterIsNotALetter()
        {
            IKata carter = new AlphabetDiamondKata('£');
            scenarioContext.Add("Carter", carter);
        }

        [When(@"Diamond is Created")]
        public void WhenDiamondIsCreated()
        {
            var carter = (AlphabetDiamondKata)scenarioContext["Carter"];
            var lines = carter.Create();
            
            scenarioContext.Add("Lines", lines);
        }


        [Then(@"the Output for A should be Empty")]
        public void ThenTheOutputForAShouldBeEmpty()
        {
            var carter = (AlphabetDiamondKata)scenarioContext["Carter"];
            var lines = (string[])scenarioContext["Lines"];
            var result = carter.OutPut();

            Debug.WriteLine(result);
            Assert.Equal(String.Empty, result);
            Assert.Equal(string.Join(Environment.NewLine, lines.Where(s => !string.IsNullOrEmpty(s))), result);
        }


        [Given(@"Center Supplied Letter Is A")]
        public void GivenCenterSuppliedLetterIsA()
        {
            IKata carter = new AlphabetDiamondKata('A');
            scenarioContext.Add("Carter", carter);
        }


        [Then(@"the Output for A should be A")]
        public void ThenTheOutputForAShouldBeA()
        {
            var carter = (AlphabetDiamondKata)scenarioContext["Carter"];
            var lines = (string[])scenarioContext["Lines"];
            var result = carter.OutPut();

            Debug.WriteLine(result);
            Assert.Equal("A", result);
            Assert.Equal(string.Join(Environment.NewLine, lines.Where(s => !string.IsNullOrEmpty(s))), result);
        }


        [Given(@"Center Supplied Letter Not A Is Z")]
        public void GivenCenterSuppliedLetterNotAIsZ()
        {
            char centerLetter = 'Z';
            IKata carter = new AlphabetDiamondKata(centerLetter);

            scenarioContext.Add("CenterLetter",centerLetter);
            scenarioContext.Add("Carter", carter);
        }


        [Then(@"the Output for Z should form a Diamond")]
        public void ThenTheOutputForZShouldFormADiamond()
        {
            var carter = (AlphabetDiamondKata)scenarioContext["Carter"];
            var lines = (string[])scenarioContext["Lines"];
            var result = carter.OutPut();

            Debug.WriteLine(result);
            Assert.Equal(string.Join(Environment.NewLine, lines), result);
        }


        [Then(@"Diamond should Contain One instance of A at Start Point")]
        public void ThenDiamondShouldContainOneInstanceOfAAtStartPoint()
        {
            const char letterA = 'A';
            var lines = (string[])scenarioContext["Lines"];
            Assert.Contains(letterA, lines[0]);
        }

        [Then(@"Diamond should Contain One instance of A at End Point")]
        public void ThenDiamondShouldContainOneInstanceOfAAtEndPoint()
        {
            const char letterA = 'A';
            var centerLetter = (char)scenarioContext["CenterLetter"];
            var position = char.ToUpper(centerLetter) - 64;
            var lines = (string[])scenarioContext["Lines"];

            Assert.Contains(letterA, lines[(position * 2) - 2]);
        }

        [Then(@"Diamond Should Contain One line for Center Point as (.*)")]
        public void ThenDiamondShouldContainOneLineForCenterPointAsLetter(char centerLetter)
        {
            var position = char.ToUpper(centerLetter) - 64;
            var lines = (string[])scenarioContext["Lines"];

            var outer = centerLetter.ToString().PadLeft(1);
            var innerSpacing = (((position - 1) * 2) - 1);
            var inner = centerLetter.ToString().PadLeft(innerSpacing + 1);
            var lineCenter = $"{outer}{inner}";
            Assert.Equal(lineCenter, lines[(position - 1)]);
        }

        [Then(@"Diamond Should Contain Two instance of a Letter on Each Line Not A")]
        public void ThenDiamondShouldContainTwoInstanceOfALetterOnEachLine()
        {
            var whitespaces = new Regex(@"\s+");
            var lines = (string[])scenarioContext["Lines"];
            var centerLetter = (char)scenarioContext["CenterLetter"];
            var centerPosition = centerLetter - 64;
            var maxLevels = centerPosition * 2 - 1;

            maxLevels -= 1;
            for ( int i=1; i<(centerPosition - 1); i++)
            {
                var letter = (char)(i + 1 + 64);
                var expected = $"{letter}{letter}";

                var actualTop = whitespaces.Replace(lines[i], "");
                var actualBottom = whitespaces.Replace(lines[maxLevels-1], "");

                Assert.Equal(expected, actualTop);
                Assert.Equal(expected, actualBottom);

                maxLevels -= 1;
            }
        }

        [Then(@"Diamond Should Contain Two instance of Matching Lines For Each Non Center Letter")]
        public void ThenDiamondShouldContainTwoInstanceOfMatchingLinesForEachNonCenterLetter()
        {
            var lines = (string[])scenarioContext["Lines"];
            var centerLetter = (char)scenarioContext["CenterLetter"];
            var centerPosition = centerLetter-64;
            var maxLevels = centerPosition * 2 - 1;

            for (int i = 0; i < centerPosition-1; i++)
            {
                var letter = (char)(i + 1 + 64);
                if (centerLetter != letter)
                {
                    var LineTop = lines[i];
                    var LineBottom = lines[maxLevels - 1];
                    Assert.Equal(LineBottom, LineTop);

                }
                maxLevels -= 1;
            }
        }
    }
}
