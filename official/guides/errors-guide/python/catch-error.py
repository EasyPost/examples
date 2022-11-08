import easypost;

try:
  easypost.Address.create({..., "strict_verify": True});
except easypost.Error as e:
  p e.json_body["code"]
