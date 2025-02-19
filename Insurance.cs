using System;
using System.Collections.Generic;
using System.Linq;

    class Insurance
    {
        static void Main(string[] args)
        {
            Policy policy1 = new Policy("P001", "Health", DateTime.Now.AddDays(15));
            Policy policy2 = new Policy("P002", "Life", DateTime.Now.AddDays(45));
            Policy policy3 = new Policy("P003", "Car", DateTime.Now.AddDays(10));
            Policy policy4 = new Policy("P001", "Health", DateTime.Now.AddDays(25));
            Policy policy5 = new Policy("P004", "Home", DateTime.Now.AddDays(20));

            HashSet<Policy> uniquePolicies = new HashSet<Policy>();
            List<Policy> linkedHashSetPolicies = new List<Policy>();
            SortedSet<Policy> sortedSetPolicies = new SortedSet<Policy>();

            AddPolicyToSets(policy1, uniquePolicies, linkedHashSetPolicies, sortedSetPolicies);
            AddPolicyToSets(policy2, uniquePolicies, linkedHashSetPolicies, sortedSetPolicies);
            AddPolicyToSets(policy3, uniquePolicies, linkedHashSetPolicies, sortedSetPolicies);
            AddPolicyToSets(policy4, uniquePolicies, linkedHashSetPolicies, sortedSetPolicies);
            AddPolicyToSets(policy5, uniquePolicies, linkedHashSetPolicies, sortedSetPolicies);

            Console.WriteLine("All Unique Policies:");
            foreach (var policy in uniquePolicies)
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("Policies Expiring Soon (Within 30 days):");
            foreach (var policy in GetPoliciesExpiringSoon(sortedSetPolicies, 30))
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("Policies with Coverage Type 'Health':");
            foreach (var policy in GetPoliciesByCoverageType(linkedHashSetPolicies, "Health"))
            {
                Console.WriteLine(policy);
            }

            Console.WriteLine("Duplicate Policies:");
            var duplicates = FindDuplicatePolicies(linkedHashSetPolicies);
            foreach (var policy in duplicates)
            {
                Console.WriteLine(policy);
            }
        }

        static void AddPolicyToSets(Policy policy, HashSet<Policy> hashSet, List<Policy> linkedHashSet, SortedSet<Policy> sortedSet)
        {
            hashSet.Add(policy);
            linkedHashSet.Add(policy);
            sortedSet.Add(policy);
        }

        static IEnumerable<Policy> GetPoliciesExpiringSoon(SortedSet<Policy> sortedSet, int days)
        {
            DateTime currentDate = DateTime.Now;
            return sortedSet.Where(policy => (policy.ExpiryDate - currentDate).Days <= days);
        }

        static IEnumerable<Policy> GetPoliciesByCoverageType(List<Policy> linkedHashSet, string coverageType)
        {
            return linkedHashSet.Where(policy => policy.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase));
        }

        static IEnumerable<Policy> FindDuplicatePolicies(List<Policy> linkedHashSet)
        {
            var duplicates = linkedHashSet.GroupBy(policy => policy.PolicyNumber)
                                          .Where(group => group.Count() > 1)
                                          .SelectMany(group => group)
                                          .ToList();
            return duplicates;
        }
    }

    class Policy : IComparable<Policy>
    {
        public string PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Policy(string policyNumber, string coverageType, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            CoverageType = coverageType;
            ExpiryDate = expiryDate;
        }

        public int CompareTo(Policy other)
        {
            if (other == null)
                return 1;

            return this.ExpiryDate.CompareTo(other.ExpiryDate);
        }

        public override bool Equals(object obj)
        {
            if (obj is Policy other)
            {
                return this.PolicyNumber.Equals(other.PolicyNumber);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        public override string ToString()
        {
            return "PolicyNumber: " + PolicyNumber + ", Coverage: " + CoverageType + ", Expiry: " + ExpiryDate.ToShortDateString();
        }
    }
