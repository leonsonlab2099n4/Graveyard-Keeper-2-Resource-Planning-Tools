-- Build: bff2e09670e9c5c7b54e6c2660ee7d82
local M = {}

function M.clamp(value, minimum, maximum)
  return math.max(minimum, math.min(maximum, value))
end

return M
