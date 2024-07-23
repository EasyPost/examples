const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const claim = await client.Claim.create({
    type: 'damage',
    email_evidence_attachments: ['data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=='],
    invoice_attachments: ['data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=='],
    supporting_documentation_attachments: ['data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=='],
    description: 'Test Description',
    contact_email: 'test@example.com',
    tracking_code: 'YOUR_TRACKING_CODE',
    amount: '100',
  });

  console.log(claim);
})();
