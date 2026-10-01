---
name: ep-example-authoring
description: Author or update EasyPost examples using repository conventions for directory structure, endpoint/action naming, versioning, placeholder values, and minimal runnable snippet shape across docs, guides, and responses.
---

# EasyPost Example Authoring Skill

Use this skill when creating or updating examples in this repository.

## Purpose

Keep examples consistent across languages and versions while preserving the repo's docs-site ingestion conventions.

## Scope

This skill applies to:

- `official/docs/*`
- `official/guides/*`
- `official/docs/responses/*`

## Source Of Truth Priority

When conventions conflict, use this order:

1. Existing `official/docs/curl/current` endpoint/action directory and filename layout.
2. Existing `official/docs/<language>/current` precedent for that endpoint.
3. `README.md` conventions in the Development section.
4. Fixture-aligned values from `official/fixtures`.

## Repository Structure Rules

- `official/docs/<language>/current` is the authoritative, latest snippet set used by downstream sites.
- `official/docs/<language>/vN` directories preserve old major-version examples.
- `official/docs/responses` is not versioned and does not have a `current` directory.
- `official/guides` contains guide-specific examples and payload assets.

## Endpoint Directory And Filename Rules

### Docs snippets

- Place snippets under `official/docs/<language>/current/<endpoint>/<action>.<ext>`.
- Endpoint directories use kebab-case path names, matching curl endpoint folder names.
- Action filenames use kebab-case and should match curl script stem.

Examples:

- `official/docs/curl/current/addresses/create-and-verify.sh`
- `official/docs/node/current/addresses/create-and-verify.js`
- `official/docs/python/current/scan-form/list.py`

### Response snippets

- Place responses under `official/docs/responses/<endpoint>/<action>.json`.
- Keep response endpoint/action naming aligned with curl endpoint/action naming.

Examples:

- `official/docs/responses/addresses/create.json`
- `official/docs/responses/rates/retrieve-stateless.json`

## Snippet Content Rules

Each example should be minimally viable and runnable as-is except placeholders.

Required shape:

1. Import the library.
2. Instantiate client with `EASYPOST_API_KEY` placeholder.
3. Perform one focused API call.
4. Print/log the result.

Keep snippets:

- Small and focused.
- Free of unrelated setup, abstractions, or control flow.
- Consistent with existing naming and call style in that language.

## Placeholder Rules

- Use `EASYPOST_API_KEY` for API key placeholder.
- Use object ID placeholders by prefix plus ellipsis, e.g. `adr_...`, `shp_...`, `sf_...`, `ca_...`.
- Use open-source/non-PII sample data.
- Prefer fixture-aligned values when possible.

## Language-Specific Precedent Notes

Use existing files in each language's `current` directory as direct style precedent.

- Curl: one command per file, `curl -X ...`, JSON body inline, API key via `-u "EASYPOST_API_KEY":`.
- Node: CommonJS `require`, async IIFE, `console.log(...)` output.
- Python: module import + direct call sequence + `print(...)`.
- Ruby: `require 'easypost'`, client creation, call, `puts` output.
- PHP: instantiate client, execute call, `echo` output.
- C#: async `Main`, typed parameters object, JSON serialization to console.
- Go: helper function snippet style, make call, `fmt.Println(...)`.
- Java: class-per-file examples with `main`, but package naming may intentionally differ from folder name for historical consistency.

Java package caution:

- Do not auto-rename package declarations to match folder names.
- Follow existing local precedent for that endpoint set.
- Some endpoint folders intentionally map to shared package namespaces.

## Versioning Workflow

When a client library releases a new major version:

1. Copy `official/docs/<language>/current` to `official/docs/<language>/v<previous_major>`.
2. Update only `current` for latest major syntax/usage changes.
3. Keep endpoint/action coverage and naming consistent between versions unless API/library behavior requires divergence.

## Response Generation (Required For New/Updated Examples)

When authoring or changing docs examples, make sure the matching response JSON is generated and updated.

Quick workflow:

1. `cd tools/build_doc_json_responses`
2. Remove related cassette file(s) in `tests/cassettes` for the response(s) you need to regenerate.
3. Run `just generate` with required API keys (run it twice; first pass records, second pass writes responses):

```bash
# Source `.env` file or variables
just generate
```

4. Copy generated files from `tools/build_doc_json_responses/responses` into `official/docs/responses`.
5. Keep endpoint/action naming aligned between example snippets and response JSON paths.

For complete setup, troubleshooting, and formatting details, see:

- `tools/build_doc_json_responses/README.md`

## Consistency Checklist Before Commit

1. Filename and folder parity against curl `current` action names.
2. Response filename is action-only (no endpoint prefix).
3. Snippet uses minimal runnable structure and `EASYPOST_API_KEY`.
4. Placeholder IDs follow expected prefixes.
5. New data is non-PII and fixture-aligned where possible.
6. `current` directories remain present for all language docs.
7. Matching response JSON was regenerated/updated when snippet behavior changed.

## Optional Verification Commands

```bash
# Ensure required current dirs still exist
bash test/ensure-current-dirs-exist.sh

# Spot-check endpoint/action parity shape
find official/docs/curl/current -maxdepth 2 -type f | head
find official/docs/responses -maxdepth 2 -type f | head
```

## Anti-Patterns

- Adding extra helper frameworks or architecture in simple snippets.
- Introducing language-specific style drift not already present in that language's `current` precedent.
- Changing historical version directories when the change should be only in `current`.
