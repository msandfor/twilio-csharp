/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.Tests.TwiML 
{

    [TestFixture]
    public class SayTest : TwilioTest 
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Say();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say></Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Say("message", Say.VoiceEnum.Man, 1, Say.LanguageEnum.DaDk);
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say voice=\"man\" loop=\"1\" language=\"da-DK\">message</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Say();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say newParam1=\"value\" newParam2=\"1\"></Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new Say();

            elem.SsmlBreak(SsmlBreak.StrengthEnum.None, "time");

            elem.SsmlEmphasis("words", SsmlEmphasis.LevelEnum.Strong);

            elem.SsmlLang("words", SsmlLang.XmlLangEnum.DaDk);

            elem.SsmlP("words");

            elem.SsmlPhoneme("words", SsmlPhoneme.AlphabetEnum.Ipa, "ph");

            elem.SsmlProsody("words", "volume", "rate", "pitch");

            elem.SsmlS("words");

            elem.SsmlSayAs("words", SsmlSayAs.InterpretAsEnum.Character, SsmlSayAs.RoleEnum.Mdy);

            elem.SsmlSub("words", "alias");

            elem.SsmlW("words", "role");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>" + Environment.NewLine +
                "  <break strength=\"none\" time=\"time\"></break>" + Environment.NewLine +
                "  <emphasis level=\"strong\">words</emphasis>" + Environment.NewLine +
                "  <lang xml:lang=\"da-DK\">words</lang>" + Environment.NewLine +
                "  <p>words</p>" + Environment.NewLine +
                "  <phoneme alphabet=\"ipa\" ph=\"ph\">words</phoneme>" + Environment.NewLine +
                "  <prosody volume=\"volume\" rate=\"rate\" pitch=\"pitch\">words</prosody>" + Environment.NewLine +
                "  <s>words</s>" + Environment.NewLine +
                "  <say-as interpret-as=\"character\" role=\"mdy\">words</say-as>" + Environment.NewLine +
                "  <sub alias=\"alias\">words</sub>" + Environment.NewLine +
                "  <w role=\"role\">words</w>" + Environment.NewLine +
                "</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Say();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>Here is the content</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Say();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Say();
            var child = new SsmlBreak();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>" + Environment.NewLine +
                "  <break>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </break>" + Environment.NewLine +
                "</Say>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Say();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Say>before<Child>content</Child>after</Say>",
                elem.ToString()
            );
        }
    }

}