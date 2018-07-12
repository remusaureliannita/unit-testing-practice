using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCanceledby_AdminCancelling_ReturnsTrue()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCanceledBy_SameUserCancelling_ShouldReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation{MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ShouldReturnFalse()
        {
            var reservation = new Reservation{MadeBy = new User()};

            var result = reservation.CanBeCancelledBy(new User());
        }
    }
}
