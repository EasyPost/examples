# frozen_string_literal: true

Gem::Specification.new do |spec|
  spec.name                   = 'examples'
  spec.version                = '0.1.0'
  spec.required_ruby_version  = '>= 2.7'
  spec.summary                = 'Code examples for the EasyPost API'
  spec.description            = 'Code examples for the EasyPost API.'
  spec.authors                = ['EasyPost']
  spec.email                  = 'oss@easypost.com'
  spec.homepage               = 'https://github.com/easypost/examples'
  spec.license                = 'MIT'

  spec.add_dependency 'easypost', '~> 7'

  spec.add_development_dependency 'rubocop', '= 1.73'
  spec.add_development_dependency 'rubocop-rspec', '~> 2.31' # Can't upgrade to v3 until we drop Ruby 2.7
end
