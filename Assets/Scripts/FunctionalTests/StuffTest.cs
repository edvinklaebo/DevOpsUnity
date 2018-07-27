using System.Collections;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace FunctionalTests
{
    public class StuffTest {

        [Test]
        public void NewTestScriptSimplePasses() {
            // Use the Assert class to test conditions.
        }

        [UnityTest]
        public IEnumerator GameObject_WithRigidBody_WillBeAffectedByPhysics()
        {
            var go = new GameObject();
            go.AddComponent<Rigidbody>();
            var originalPosition = go.transform.position.y;

            yield return new WaitForFixedUpdate();

            Assert.AreNotEqual(originalPosition, go.transform.position.y);
        }

        // A UnityTest behaves like a coroutine in PlayMode
        // and allows you to yield null to skip a frame in EditMode
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            yield return null;
        }
    }
}
