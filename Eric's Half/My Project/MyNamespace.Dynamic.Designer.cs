using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Software_Engineering.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Delivery m_Delivery;

            public Delivery Delivery
            {
                [DebuggerHidden]
                get
                {
                    m_Delivery = Create__Instance__(m_Delivery);
                    return m_Delivery;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Delivery))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Delivery);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Delivery_Final m_Delivery_Final;

            public Delivery_Final Delivery_Final
            {
                [DebuggerHidden]
                get
                {
                    m_Delivery_Final = Create__Instance__(m_Delivery_Final);
                    return m_Delivery_Final;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Delivery_Final))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Delivery_Final);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Delivery_Guest m_Delivery_Guest;

            public Delivery_Guest Delivery_Guest
            {
                [DebuggerHidden]
                get
                {
                    m_Delivery_Guest = Create__Instance__(m_Delivery_Guest);
                    return m_Delivery_Guest;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Delivery_Guest))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Delivery_Guest);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public OrderSummary m_OrderSummary;

            public OrderSummary OrderSummary
            {
                [DebuggerHidden]
                get
                {
                    m_OrderSummary = Create__Instance__(m_OrderSummary);
                    return m_OrderSummary;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_OrderSummary))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_OrderSummary);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Payment m_Payment;

            public Payment Payment
            {
                [DebuggerHidden]
                get
                {
                    m_Payment = Create__Instance__(m_Payment);
                    return m_Payment;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Payment))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Payment);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Payment_Guest m_Payment_Guest;

            public Payment_Guest Payment_Guest
            {
                [DebuggerHidden]
                get
                {
                    m_Payment_Guest = Create__Instance__(m_Payment_Guest);
                    return m_Payment_Guest;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Payment_Guest))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Payment_Guest);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Reciept_Card m_Reciept_Card;

            public Reciept_Card Reciept_Card
            {
                [DebuggerHidden]
                get
                {
                    m_Reciept_Card = Create__Instance__(m_Reciept_Card);
                    return m_Reciept_Card;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Reciept_Card))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Reciept_Card);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Reciept_Cash m_Reciept_Cash;

            public Reciept_Cash Reciept_Cash
            {
                [DebuggerHidden]
                get
                {
                    m_Reciept_Cash = Create__Instance__(m_Reciept_Cash);
                    return m_Reciept_Cash;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Reciept_Cash))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Reciept_Cash);
                }
            }
        }
    }
}