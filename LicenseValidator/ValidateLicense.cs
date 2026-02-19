using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseValidator
{
    [RunInstaller(true)]
    public class ValidateLicense : Installer
    {
        //public override void Install(IDictionary stateSaver)
        //{
        //    base.Install(stateSaver);

        //    string serial = Context.Parameters["SERIAL"];

        //    if (!IsValidKey(serial))
        //    {
        //        MessageBox.Show(
        //            "Invalid License Key.\n\nCorrect Key: ICOMM-LCP-2025",
        //            "License Validation Failed",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);

        //        throw new InstallException("Invalid License Key");
        //    }
        //}

        //private bool IsValidKey(string key)
        //{
        //    return string.Equals(
        //        key?.Trim(),
        //        "ICOMM-LCP-2025",
        //        StringComparison.OrdinalIgnoreCase);
        //}

        //private const string VALID_KEY = "1212-3333-1616-1216";
        //public override void Install(IDictionary stateSaver)
        //{
        //    base.Install(stateSaver);

        //    // Data coming from Setup Project
        //    string userKey = Context.Parameters["CustomActionData"];

        //    if (!IsValidKey(userKey))
        //    {
        //        MessageBox.Show(
        //            "Invalid License Key.\n\n" +
        //            "Expected Format:\n" +
        //            "1212-3333-1616-1216",
        //            "License Validation Failed",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);

        //        throw new InstallException("Invalid License Key");
        //    }
        //}

        //private bool IsValidKey(string key)
        //{
        //    if (string.IsNullOrWhiteSpace(key))
        //        return false;

        //    key = key.Trim();

        //    // 1️⃣ FORMAT CHECK (4+4+4+4 digits)
        //    if (!Regex.IsMatch(key, @"^\d{4}-\d{4}-\d{4}-\d{4}$"))
        //        return false;

        //    // 2️⃣ EXACT MATCH CHECK
        //    return string.Equals(
        //        key,
        //        VALID_KEY,
        //        StringComparison.Ordinal);
        //}


        // ✅ Your valid license key
        private const string VALID_KEY = "1212-3333-1616-1216";

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            // 🔹 Read serial number from Customer Information dialog
            // This comes from PIDKEY
            string rawKey = Context.Parameters["PIDKEY"];

            if (string.IsNullOrWhiteSpace(rawKey))
            {
                MessageBox.Show(
                    "License key is required.",
                    "License Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                throw new InstallException("License key missing");
            }

            // 🔹 Validate license
            if (!IsValidKey(rawKey))
            {
                MessageBox.Show(
                    "Invalid License Key.\n\nExpected Format:\n0000-1111-2222-3333",
                    "License Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                throw new InstallException("Invalid License Key");
            }
        }

        // ==========================================================
        // 🔐 LICENSE VALIDATION LOGIC
        // ==========================================================

        private bool IsValidKey(string inputKey)
        {
            // Normalize both keys → digits only
            string normalizedInput = NormalizeKey(inputKey);
            string normalizedValid = NormalizeKey(VALID_KEY);

            // Compare
            return string.Equals(
                normalizedInput,
                normalizedValid,
                StringComparison.Ordinal);
        }

        // ==========================================================
        // 🔹 Removes dashes, unicode chars, spaces → digits only
        // ==========================================================
        private string NormalizeKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return string.Empty;

            // Keep digits only
            return Regex.Replace(key, @"\D", "");
        }
    }
}

