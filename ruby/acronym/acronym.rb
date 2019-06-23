class Acronym
    def self.abbreviate(string)
        acronym = ""
        string.split(" ").each do |word|
            next if word == "-"

            acronym += word[0].upcase
            if word.include?("-")
                acronym += word[word.index("-") + 1].upcase
            end
        end
        return acronym
    end
end
