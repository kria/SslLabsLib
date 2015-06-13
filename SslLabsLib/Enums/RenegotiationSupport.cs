using System;

namespace SslLabsLib.Enums
{
    [Flags]
    public enum RenegotiationSupport
    {
        /// <summary>
        /// Insecure client-initiated renegotiation is supported
        /// </summary>
        InsecureClientInitiatedSupported = 1,

        /// <summary>
        /// Secure renegotiation is supported
        /// </summary>
        SecureSupported = 2,

        /// <summary>
        /// Secure client-initiated renegotiation is supported
        /// </summary>
        SecureClientInitiatedSupported = 4,

        /// <summary>
        /// The server requires secure renegotiation support
        /// </summary>
        ServerRequiresSecure = 8,

        // TODO: Remove this when Restsharp handles Flags
        Unused3 = 3,
        Unused5 = 5,
        Unused6 = 6,
        Unused7 = 7,
        Unused9 = 9,
        Unused10 = 10,
        Unused11 = 11,
        Unused12 = 12,
        Unused13 = 13,
        Unused14 = 14,
        Unused15 = 15,
        Unused17 = 17,
        Unused18 = 18,
        Unused19 = 19,
        Unused20 = 20,
        Unused21 = 21,
        Unused22 = 22,
        Unused23 = 23,
        Unused24 = 24,
        Unused25 = 25,
        Unused26 = 26,
        Unused27 = 27,
        Unused28 = 28,
        Unused29 = 29,
        Unused30 = 30,
        Unused31 = 31,
        Unused33 = 33,
        Unused34 = 34,
        Unused35 = 35,
        Unused36 = 36,
        Unused37 = 37,
        Unused38 = 38,
        Unused39 = 39,
        Unused40 = 40,
        Unused41 = 41,
        Unused42 = 42,
        Unused43 = 43,
        Unused44 = 44,
        Unused45 = 45,
        Unused46 = 46,
        Unused47 = 47,
        Unused48 = 48,
        Unused49 = 49,
        Unused50 = 50,
        Unused51 = 51,
        Unused52 = 52,
        Unused53 = 53,
        Unused54 = 54,
        Unused55 = 55,
        Unused56 = 56,
        Unused57 = 57,
        Unused58 = 58,
        Unused59 = 59,
        Unused60 = 60,
        Unused61 = 61,
        Unused62 = 62,
        Unused63 = 63,
        Unused65 = 65,
        Unused66 = 66,
        Unused67 = 67,
        Unused68 = 68,
        Unused69 = 69,
        Unused70 = 70,
        Unused71 = 71,
        Unused72 = 72,
        Unused73 = 73,
        Unused74 = 74,
        Unused75 = 75,
        Unused76 = 76,
        Unused77 = 77,
        Unused78 = 78,
        Unused79 = 79,
        Unused80 = 80,
        Unused81 = 81,
        Unused82 = 82,
        Unused83 = 83,
        Unused84 = 84,
        Unused85 = 85,
        Unused86 = 86,
        Unused87 = 87,
        Unused88 = 88,
        Unused89 = 89,
        Unused90 = 90,
        Unused91 = 91,
        Unused92 = 92,
        Unused93 = 93,
        Unused94 = 94,
        Unused95 = 95,
        Unused96 = 96,
        Unused97 = 97,
        Unused98 = 98,
        Unused99 = 99,
        Unused100 = 100,
        Unused101 = 101,
        Unused102 = 102,
        Unused103 = 103,
        Unused104 = 104,
        Unused105 = 105,
        Unused106 = 106,
        Unused107 = 107,
        Unused108 = 108,
        Unused109 = 109,
        Unused110 = 110,
        Unused111 = 111,
        Unused112 = 112,
        Unused113 = 113,
        Unused114 = 114,
        Unused115 = 115,
        Unused116 = 116,
        Unused117 = 117,
        Unused118 = 118,
        Unused119 = 119,
        Unused120 = 120,
        Unused121 = 121,
        Unused122 = 122,
        Unused123 = 123,
        Unused124 = 124,
        Unused125 = 125,
        Unused126 = 126,
        Unused127 = 127,
        Unused129 = 129,
        Unused130 = 130,
        Unused131 = 131,
        Unused132 = 132,
        Unused133 = 133,
        Unused134 = 134,
        Unused135 = 135,
        Unused136 = 136,
        Unused137 = 137,
        Unused138 = 138,
        Unused139 = 139,
        Unused140 = 140,
        Unused141 = 141,
        Unused142 = 142,
        Unused143 = 143,
        Unused144 = 144,
        Unused145 = 145,
        Unused146 = 146,
        Unused147 = 147,
        Unused148 = 148,
        Unused149 = 149,
        Unused150 = 150,
        Unused151 = 151,
        Unused152 = 152,
        Unused153 = 153,
        Unused154 = 154,
        Unused155 = 155,
        Unused156 = 156,
        Unused157 = 157,
        Unused158 = 158,
        Unused159 = 159,
        Unused160 = 160,
        Unused161 = 161,
        Unused162 = 162,
        Unused163 = 163,
        Unused164 = 164,
        Unused165 = 165,
        Unused166 = 166,
        Unused167 = 167,
        Unused168 = 168,
        Unused169 = 169,
        Unused170 = 170,
        Unused171 = 171,
        Unused172 = 172,
        Unused173 = 173,
        Unused174 = 174,
        Unused175 = 175,
        Unused176 = 176,
        Unused177 = 177,
        Unused178 = 178,
        Unused179 = 179,
        Unused180 = 180,
        Unused181 = 181,
        Unused182 = 182,
        Unused183 = 183,
        Unused184 = 184,
        Unused185 = 185,
        Unused186 = 186,
        Unused187 = 187,
        Unused188 = 188,
        Unused189 = 189,
        Unused190 = 190,
        Unused191 = 191,
        Unused192 = 192,
        Unused193 = 193,
        Unused194 = 194,
        Unused195 = 195,
        Unused196 = 196,
        Unused197 = 197,
        Unused198 = 198,
        Unused199 = 199,
        Unused200 = 200,
        Unused201 = 201,
        Unused202 = 202,
        Unused203 = 203,
        Unused204 = 204,
        Unused205 = 205,
        Unused206 = 206,
        Unused207 = 207,
        Unused208 = 208,
        Unused209 = 209,
        Unused210 = 210,
        Unused211 = 211,
        Unused212 = 212,
        Unused213 = 213,
        Unused214 = 214,
        Unused215 = 215,
        Unused216 = 216,
        Unused217 = 217,
        Unused218 = 218,
        Unused219 = 219,
        Unused220 = 220,
        Unused221 = 221,
        Unused222 = 222,
        Unused223 = 223,
        Unused224 = 224,
        Unused225 = 225,
        Unused226 = 226,
        Unused227 = 227,
        Unused228 = 228,
        Unused229 = 229,
        Unused230 = 230,
        Unused231 = 231,
        Unused232 = 232,
        Unused233 = 233,
        Unused234 = 234,
        Unused235 = 235,
        Unused236 = 236,
        Unused237 = 237,
        Unused238 = 238,
        Unused239 = 239,
        Unused240 = 240,
        Unused241 = 241,
        Unused242 = 242,
        Unused243 = 243,
        Unused244 = 244,
        Unused245 = 245,
        Unused246 = 246,
        Unused247 = 247,
        Unused248 = 248,
        Unused249 = 249,
        Unused250 = 250,
        Unused251 = 251,
        Unused252 = 252,
        Unused253 = 253,
        Unused254 = 254,
        Unused255 = 255
    }
}