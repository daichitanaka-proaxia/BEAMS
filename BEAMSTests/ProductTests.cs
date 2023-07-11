using BEAMS;

namespace BEAMSTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ConfirmGetInfo()
        {
            var product1 = new Product("�X�j�[�J�[",13200,"���l�C���i�̂��ߍw����̕ԕi�s��");
            var expected1 = "�X�j�[�J�[ 13,200 �~ ���l�C���i�̂��ߍw����̕ԕi�s��";
            Assert.AreEqual(expected1, product1.GetInfo());

            var product2 = new Product("�`�m�p��", 13200, "�r�[���X�̕S���i");
            var expected2 = "�`�m�p�� 13,200 �~ �r�[���X�̕S���i";
            Assert.AreEqual(expected2, product2.GetInfo());
        }
    }
}