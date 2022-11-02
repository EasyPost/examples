# Retrieve the authenticated user
curl -X GET https://api.easypost.com/v2/users \
  -u "$EASYPOST_API_KEY":

# Retrieve a child user
curl -X GET https://api.easypost.com/v2/users/user_... \
  -u "$EASYPOST_API_KEY":
