using NUnit.Framework;

namespace TurboCollections.Test {
    public class TurboListTests {
        [Test]
        public void NewListIsEmpty() {
            var list = new TurboList<int>();
            Assert.Zero(list.Count);
        }

        [Test]
        public void AddingAnElementIncreasesCountToOne() {
            var list = new TurboList<int>();
            list.Add(5);
            Assert.AreEqual(1, list.Count);
        }

        [Test, TestCase(5), TestCase(7)]
        public void AddingMultipleElementsIncreasesCountToOne(int numberOfElements) {
            var list = new TurboList<int>();
            for (int i = 0; i < numberOfElements; i++)
                list.Add(5);
            Assert.AreEqual(numberOfElements, list.Count);
        }

        [Test]
        public void AnAddedElementCanBeGotten() {
            var list = new TurboList<int>();
            list.Add(1337);
            Assert.AreEqual(1337, list.Get(0));
        }

        [Test]
        public void RemovingAllAddedElements() {
            var list = new TurboList<int>();
            list.Add(5);
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void RemoveOneSpecificItemAndMoveElementsToLeft() {
            var list = new TurboList<int>();
            list.Add(6);
            list.Add(9);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Add(8);
            list.RemoveAt(0);
            Assert.AreEqual(9, list.Get(0));
        }

        [Test]
        public void SeeIfItemExists() {
            var list = new TurboList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Add(9);
            Assert.True(list.Contains(5));
            Assert.False(list.Contains(12));
        }

        [Test]
        public void ReturnIndexOf() {
            var list = new TurboList<int>();
            list.Add(11);
            list.Add(32);
            list.Add(56);
            list.Add(71);
            list.Add(90);
            Assert.AreEqual(2, list.IndexOf(56));
        }

        [Test]
        public void RemoveSpecifiedItemAtIndex() {
            var list = new TurboList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Remove(3);
            Assert.AreEqual(4, 2);
        }
    }
}
