try {
  \EasyPost\Address::create(array(..., "strict_verify" => true));
catch (\EasyPost\Error $e) {
  echo $e->ecode;
}
