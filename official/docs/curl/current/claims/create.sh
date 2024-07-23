curl -X POST https://api.easypost.com/v2/insurances \
  -u "EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "type": "damage",
    "email_evidence_attachments": ["REPLACE_WITH_BASE64_STRING"],
    "invoice_attachments": ["REPLACE_WITH_BASE64_STRING"],
    "supporting_documentation_attachments": ["REPLACE_WITH_BASE64_STRING"],
    "description": "Test description",
    "contact_email": "test@example.com",
    "tracking_code": "YOUR_TRACKING_CODE",
    "amount": "100.00"
  }'
