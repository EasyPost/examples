const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const claim = await client.Claim.create({
    type: 'damage',
    email_evidence_attachments: [
      'REPLACE_WITH_BASE64_STRING',
    ],
    invoice_attachments: [
      'REPLACE_WITH_BASE64_STRING',
    ],
    supporting_documentation_attachments: [
      'REPLACE_WITH_BASE64_STRING',
    ],
    description: 'Test Description',
    contact_email: 'test@example.com',
    tracking_code: 'YOUR_TRACKING_CODE',
    amount: '100',
  });

  console.log(claim);
})();
